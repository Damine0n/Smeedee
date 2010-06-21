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
// The project webpage is located at http://smeedee.org/
// which contains all the neccessary information.
// </contactinfo>

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using Smeedee.Client.Framework;
using Smeedee.Client.Framework.Services;
using Smeedee.Client.Framework.ViewModel;
using Smeedee.DomainModel.Config;
using Smeedee.DomainModel.Framework;
using Smeedee.DomainModel.Framework.Logging;
using Smeedee.DomainModel.SourceControl;
using Smeedee.Widget.SourceControl.ViewModels;
using TinyMVVM.Framework.Services;


namespace Smeedee.Widget.SourceControl.Controllers
{
    public class CommitStatisticsController : ChangesetStandAloneController<CommitStatisticsForDate>
    {
        private readonly IRepository<Configuration> configRepository;
        private readonly IPersistDomainModels<Configuration> configPersisterRepository;
        private int commitTimespan;
        private bool configLoaded;
        
        public CommitStatisticsController(
            BindableViewModel<CommitStatisticsForDate> viewModel, 
            IRepository<Changeset> changesetRepo, 
            IInvokeBackgroundWorker<IEnumerable<Changeset>> backgroundWorker, 
            ITimer timer, 
            IUIInvoker uiInvoke,
            IRepository<Configuration> configRepo,
            IPersistDomainModels<Configuration> configPersister, ILog logger)
            : base(viewModel, changesetRepo, backgroundWorker, timer, uiInvoke, logger)
        {
            configRepository = configRepo;
            configPersisterRepository = configPersister;


            refreshNotifier.Start(30000);

            LoadDummyDataIntoViewModel();
            
            LoadConfig();
            LoadData();
        }

        private void LoadDummyDataIntoViewModel() {
            
            ViewModel.Data.Add(new CommitStatisticsForDate()
            {
                Date = DateTime.Today,
                NumberOfCommits = 0
            });
            ViewModel.Data.Add(new CommitStatisticsForDate()
            {
                Date = DateTime.Today.AddDays(1),
                NumberOfCommits = 0
            });
        }

        private void LoadConfig()
        {
            asyncClient.RunAsyncVoid(() =>
            {
                try
                {
                    var allConfigSpec = new AllSpecification<Configuration>();
                    var config = configRepository
                        .Get(allConfigSpec)
                        .Where(c => c.Name.Equals(("Commit Statistics")))
                        .SingleOrDefault();

                    LoadSettings(config);
                }
                catch (Exception exception)
                {
                    LogErrorMsg(exception);
                }
            });
        }


        private void LoadSettings(Configuration config)
        {
            if (config != null)
            {
                LoadTimespanSetting(config.GetSetting("timespan"));
            }
            else
            {
                CreateDefaultSetting();
            }
        }

        private void LoadTimespanSetting(SettingsEntry timespanSetting)
        {
            try
            {
                commitTimespan = Int32.Parse(timespanSetting.Value.Trim());
                configLoaded = true;
            }
            catch (Exception exception)
            {
                LogWarningMsg(exception);
            }
        }

        private void CreateDefaultSetting()
        {
            var newConfig = new Configuration("Commit Statistics");
            newConfig.NewSetting("timespan", "14");
            configPersisterRepository.Save(newConfig);
        }

        protected override void OnNotifiedToRefresh(object sender, EventArgs e)
        {
            LoadConfig();
            LoadData();
        }

        protected override void LoadDataIntoViewModel(IEnumerable<Changeset> qChangesets)
        {
            
            var commitStatisticsForDates = (from changeset in qChangesets
                                            where changeset.Time.Date > DateTime.Now.AddDays(-commitTimespan)
                                            group changeset by changeset.Time.Date
                                                into g
                                                select new CommitStatisticsForDate()
                                                       {
                                                           Date = g.Key,
                                                           NumberOfCommits = g.Count(),
                                                       }).OrderBy(r => r.Date);

            ViewModel.Data.Clear();

            if (commitTimespan <= 0)
            {
                LoadDummyDataIntoViewModel();

                if(configLoaded)
                    throw new InvalidOperationException("Start date must be before or at end date");

                return;
            }
        
            foreach (var row in FillInMissingDates(commitStatisticsForDates))
                ViewModel.Data.Add(row);

        }

        private IOrderedEnumerable<CommitStatisticsForDate> FillInMissingDates(IEnumerable<CommitStatisticsForDate> commitStatistics)
        {

            if (commitStatistics == null)
                throw new ArgumentNullException("commitStatistics");

            var allCommits = new Dictionary<DateTime, CommitStatisticsForDate>();

            foreach (DateTime date in GetDatesInRage(DateTime.Today.AddDays(-(commitTimespan-1)), DateTime.Today))
            {
                allCommits.Add(date, new CommitStatisticsForDate() { Date = date, NumberOfCommits =  0});
            }

            foreach (CommitStatisticsForDate commit in commitStatistics)
            {
                allCommits[commit.Date] = commit;
            }

            return allCommits.Values.OrderBy(r => r.Date);

        }

        private IEnumerable<DateTime> GetDatesInRage(DateTime startDate, DateTime endDate)
        {
            List<DateTime> allDates = new List<DateTime>();


            DateTime currentDate = startDate;
            allDates.Add(currentDate);
            
            if (startDate == endDate)  //Note: We do this because 1 data point looks wierd in the view
            {
                allDates.Add(currentDate.AddDays(1));
                return allDates;
            }

            while (currentDate < endDate)
            {
                currentDate = currentDate.AddDays(1);
                allDates.Add(currentDate);
            }

            return allDates;

        }
    }
}