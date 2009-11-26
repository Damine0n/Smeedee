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
using APD.Client.Framework;
using APD.Client.Widget.BurndownChart.ViewModel;
using APD.Tests;
using TinyBDD.Specification.NUnit;
using NUnit.Framework;


namespace APD.Client.Widget.BurndownChart.BurndownChartViewModelSpecs
{   
    public class Shared
    {
        protected BurndownChartViewModel viewModel;
    }
    
    [TestFixture]
    public class When_the_BurndownChartViewModel_is_spawned : Shared
    {
        [SetUp]
        public void Setup()
        {
            viewModel = new BurndownChartViewModel(new NoUIInvocation());
        }

        [Test]
        public void should_have_ErrorMessage_property()
        {
            viewModel.ErrorMessage.ShouldBeInstanceOfType<String>();
        }

        [Test]
        public void should_have_ActualBurndown_property()
        {
            viewModel.ActualBurndown.ShouldBeInstanceOfType<List<BurndownChartCoordinate>>();
            Assert.IsNotNull(viewModel.ActualBurndown);
        }

        [Test]
        public void should_have_IdealBurndown_property()
        {
            viewModel.IdealBurndown.ShouldBeInstanceOfType<List<BurndownChartCoordinate>>();
            Assert.IsNotNull(viewModel.IdealBurndown);
        }

        [Test]
        public void should_have_ProjectName_property()
        {
            viewModel.ProjectName = "Project Name";
            viewModel.ProjectName.ShouldBeInstanceOfType<String>();
        }

        [Test]
        public void should_have_IterationName_property()
        {
            viewModel.IterationName = "Iteration Name";
            viewModel.IterationName.ShouldBeInstanceOfType<String>();
        }

        [Test]
        public void should_have_error_flag_properties()
        {
            viewModel.ProjectsInRepository.ShouldBeInstanceOfType<Boolean>();
            viewModel.IterationInProject.ShouldBeInstanceOfType<Boolean>();
            viewModel.TasksInIteration.ShouldBeInstanceOfType<Boolean>();
        }

        [Test]
        public void should_have_all_error_flags_set_to_false()
        {
            viewModel.ProjectsInRepository.ShouldBe(false);
            viewModel.IterationInProject.ShouldBe(false);
            viewModel.TasksInIteration.ShouldBe(false);
        }
    }

    [TestFixture]
    public class When_error_flags_are_changed : Shared   
    {
        [SetUp]
        public void Setup()
        {
            viewModel = new BurndownChartViewModel(new NoUIInvocation());
        }

        [Test]
        public void should_notify_user_when_there_are_no_projects_in_repository()
        {
            Assert.AreSame("No projects with the given name exists in the repository", viewModel.ErrorMessage);
        }

        [Test]
        public void should_notify_user_when_there_are_no_iterations_for_given_project()
        {
            viewModel.ProjectsInRepository = true;
            viewModel.IterationInProject = false;
            viewModel.TasksInIteration = false;
            Assert.AreSame("There are no iterations in the given project", viewModel.ErrorMessage);
        }

        [Test]
        public void should_notify_user_when_there_are_no_tasks_for_userStory()
        {
            viewModel.ProjectsInRepository = true;
            viewModel.IterationInProject = true;
            viewModel.TasksInIteration = false;
            Assert.AreSame("There are no tasks for the current iteration for the given project", viewModel.ErrorMessage);
        }
    }

    [TestFixture]
    public class When_properties_change : Shared
    {
        [SetUp]
        public void Setup()
        {
            viewModel = new BurndownChartViewModel(new NoUIInvocation());
        }

        [Test]
        public void listeners_should_be_notified_when_ProjectName_changes()
        {
            PropertyTester.TestChange<BurndownChartViewModel>(viewModel, vm => vm.ProjectName);
            Assert.IsTrue(PropertyTester.WasNotified);
        }

        [Test]
        public void listeners_should_be_notified_when_IterationName_changes()
        {
            PropertyTester.TestChange<BurndownChartViewModel>(viewModel, vm => vm.IterationName);
            Assert.IsTrue(PropertyTester.WasNotified);
        }
    }
}