using System;
using System.Collections.Generic;
using System.Text;
using FreshMvvm;
using MsAppCenter.Services.AnalyticsService;

namespace MsAppCenter.PageModels
{
    class MainPageModel : FreshBasePageModel
    {
        protected new IAnalyticsService AnalyticsService { get; private set; }

        public MainPageModel(IAnalyticsService analyticsService)
        {
            // Use dependency injection
            AnalyticsService = analyticsService;
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            // Track event example
            AnalyticsService.TrackEvent("Navigated to the MainPage",
                new Dictionary<string, string>
                {
                    { "Date", DateTime.Now.ToString("dd/MM/yyyy") },
                });

        }

    }
}
