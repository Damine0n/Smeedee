﻿#region File header

// <copyright>
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
// /copyright> 
// 
// <contactinfo>
// The project webpage is located at http://agileprojectdashboard.org/
// which contains all the neccessary information.
// </contactinfo>

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using APD.Client.Framework;
using APD.Client.Framework.Commands;
using APD.Client.Framework.Controllers;
using APD.Client.Framework.Settings;
using APD.Client.Framework.ViewModels;
using APD.Client.Widget.CI.ViewModels;
using APD.DomainModel.CI;
using APD.DomainModel.Framework;
using APD.DomainModel.Framework.Logging;
using APD.DomainModel.Users;


namespace APD.Client.Widget.CI.Controllers
{
    public enum CIProjectBuildStatusChangeEvents
    {
        ABuildFailed,
        AllBuildsSuccessful,
    }

    public class CIController : ControllerBase<CIViewModel>
    {
        private const int INACTIVE_PROJECT_THRESHOLD = 90;
        private readonly IRepository<CIServer> ciProjectRepository;
        private readonly IRepository<User> userRepository;
        private readonly FreezeViewCommandPublisher freezeViewCmdPublisher;
        private readonly UnFreezeViewCommandPublisher unFreezeViewCmdPublisher;

        private readonly IVisibleModule owningModule;

        private IInvokeBackgroundWorker<IEnumerable<CIProject>> asyncClient;
        private readonly ILog logger;

        private bool isSoundEnabled = false;
        private bool isFrozen = false;
        private bool isLoading = false;

        #region Constructor

        public CIController(IRepository<CIServer> repository, 
                            IRepository<User> userRepository,
                            INotifyWhenToRefresh notifier, 
                            IInvokeUI uiInvoker,
                            FreezeViewCommandPublisher freezeViewCmdPublisher,
                            UnFreezeViewCommandPublisher unFreezeViewCmdPublisher, 
                            IVisibleModule owningModule,
                            IClientSettingsReader settingsReader,
                            IInvokeBackgroundWorker<IEnumerable<CIProject>> backgroundWorkerInvoker,
                            ILog logger)
            : base(notifier, uiInvoker)
        {
            ciProjectRepository = repository;
            this.userRepository = userRepository;

            this.freezeViewCmdPublisher = freezeViewCmdPublisher;
            this.unFreezeViewCmdPublisher = unFreezeViewCmdPublisher;
            this.owningModule = owningModule;
            asyncClient = backgroundWorkerInvoker;
            this.logger = logger;

            ConfigureSoundSettings(settingsReader);
            LoadData();
        }

        #endregion

        private void ConfigureSoundSettings(IClientSettingsReader settingsReader)
        {
            object soundSetting = settingsReader.ReadSetting("CI_play_sound");
            if (soundSetting != null)
            {
                isSoundEnabled = (bool) soundSetting;
            }
        }

        private bool IsLoading()
        {
            return isLoading;
        }

        private void FlagIsLoading()
        {
            isLoading = true;
        }

        private void UnflagIsLoading()
        {
            isLoading = false;
        }

        private void LoadData()
        {
            asyncClient.RunAsyncVoid(() =>
            {
                FlagIsLoading();
                ViewModel.IsLoading = true;
                IEnumerable<CIProject> projects = TryGetProjects();
                bool gotProjects = projects != null;
                if (gotProjects)
                {
                    LoadDataIntoViewModel(projects);
                    ViewModel.IsLoading = false;
                    CheckProjectBuildStatusAndNotify(projects);
                }
                UnflagIsLoading();
            });
        }

        protected override void OnNotifiedToRefresh(object sender, RefreshEventArgs e)
        {
            if (!IsLoading())
                LoadData();
        }

        private IEnumerable<CIProject> TryGetProjects()
        {
            IEnumerable<CIProject> projects = null;

            try
            {
                var qServers = ciProjectRepository.Get(new AllSpecification<CIServer>());
                if (qServers.Count() > 0)
                    projects = qServers.First().Projects;
                ViewModel.HasConnectionProblems = false;
            }
            catch( Exception exception )
            {
                ViewModel.HasConnectionProblems = true;
                logger.WriteEntry(new ErrorLogEntry()
                                      {
                                          Message = exception.ToString(),
                                          Source = this.GetType().ToString(),
                                          TimeStamp = DateTime.Now
                                      });
            }

            if (projects != null)
            {
                var activeProjects =
                    projects.Where(
                        p => p.LatestBuild.StartTime > DateTime.Now.AddDays(- INACTIVE_PROJECT_THRESHOLD));
                projects = activeProjects;
            }

            return projects;
        }

        private void LoadDataIntoViewModel(IEnumerable<CIProject> projects)
        {
            uiInvoker.Invoke(() =>
            {
                foreach (var projectInfo in projects)
                    LoadProjectInfoIntoView(projectInfo);
            });
        }

        private void CheckProjectBuildStatusAndNotify(IEnumerable<CIProject> projects)
        {
            var projectsWithBrokenBuild =
                projects.Where(pi => pi.LatestBuild.Status == DomainModel.CI.BuildStatus.FinishedWithFailure);

            bool foundBrokenBuild = projectsWithBrokenBuild.Count() > 0;

            if (foundBrokenBuild && !isFrozen)
            {
                isFrozen = true;
                freezeViewCmdPublisher.Notify();
            }
            else if (!foundBrokenBuild && isFrozen)
            {
                Thread.Sleep(3000);
                isFrozen = false;
                unFreezeViewCmdPublisher.Notify();
            }
        }

        private void LoadProjectInfoIntoView(CIProject CIProject)
        {
            ProjectInfoViewModel existingProjectInfoViewModel = TryFindProjectInView(CIProject.ProjectName);
            bool projectExistsInView = existingProjectInfoViewModel != null;

            if (projectExistsInView)
            {
                UpdateExistingProject(existingProjectInfoViewModel, CIProject);
            }
            else
            {
                AddNewProject(CIProject);
            }
        }

        private void AddNewProject(CIProject CIProject)
        {
            var model = new ProjectInfoViewModel(uiInvoker);
            UpdateExistingProject(model, CIProject);
            ViewModel.Data.Add(model);
        }

        private void UpdateExistingProject(ProjectInfoViewModel model, CIProject CIProject)
        {
            BuildViewModel buildModel = model.LatestBuild;

            model.ProjectName = CIProject.ProjectName;
            model.IsSoundEnabled = isSoundEnabled;
            buildModel.StartTime = CIProject.LatestBuild.StartTime;
            buildModel.FinishedTime = CIProject.LatestBuild.FinishedTime;
            buildModel.Status = (BuildStatus) CIProject.LatestBuild.Status;
            SetBuildTrigger(CIProject.LatestBuild.Trigger, ref buildModel);
        }

        private ProjectInfoViewModel TryFindProjectInView(string projectName)
        {
            foreach (ProjectInfoViewModel exisitingProjects in ViewModel.Data)
            {
                if (exisitingProjects.ProjectName == projectName)
                {
                    return exisitingProjects;
                }
            }

            return null;
        }

        private void SetBuildTrigger(Trigger trigger, ref BuildViewModel buildViewModel)
        {
            buildViewModel.TriggeredBy = TryGetPerson(trigger.InvokedBy);
            buildViewModel.TriggerCause = trigger.Cause;
        }

        private Person TryGetPerson(string username)
        {
            Person returnPerson = new UnknownPerson(uiInvoker);

            try
            {
                var userList = userRepository.Get(new UserByUsername(username));

                if (userList.Count() > 0)
                {
                    var user = userList.First();
                    returnPerson = new Person(uiInvoker)
                                   {
                                       Username = username,
                                       Firstname = user.Firstname,
                                       Middlename = user.Middlename,
                                       Surname = user.Surname,
                                       Email = user.Email,
                                       ImageUrl = user.ImageUrl,
                                   };
                }
                else
                {
                    returnPerson = new Person(uiInvoker)
                    {
                        Username = username,
                        ImageUrl = User.unknownUser.ImageUrl
                    };
                }
            }
            catch (Exception)
            {
                returnPerson = new Person(uiInvoker)
                {
                    Username = "unknown"
                };

            }

            return returnPerson;
        }
    }
}