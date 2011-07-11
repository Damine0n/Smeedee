﻿using Smeedee.Client.Framework.ViewModel;
using Smeedee.DomainModel.Config;
using Smeedee.DomainModel.Config.SlideConfig;
using Smeedee.Widgets.GenericCharting.Controllers;
using Smeedee.Widgets.GenericCharting.ViewModels;
using Smeedee.Widgets.SL.GenericCharting.Views;
using TinyMVVM.Framework;

namespace Smeedee.Widgets.SL.GenericCharting
{
    [WidgetInfo(Name = "Generic Charting",
                Description = "Used to add generic charting",
                Author = "Smeedee team",
                Version = "0.1",
                Tags = new[] { CommonTags.Charting })]
    public class GenericChartingWidget : Client.Framework.ViewModel.Widget
    {

        private ChartController controller;


        public GenericChartingWidget()
        {
            Title = "Generic Charting";

            var viewModel = GetInstance<ChartViewModel>();

            controller = NewController<ChartController>();

            View = new ChartView { DataContext = controller.ViewModel };
            SettingsView = new ChartView { DataContext = controller.ViewModel };
        }

        public override void Configure(DependencyConfigSemantics config)
        {
            config.Bind<ChartViewModel>().To<ChartViewModel>().InSingletonScope();
        }

    }
}