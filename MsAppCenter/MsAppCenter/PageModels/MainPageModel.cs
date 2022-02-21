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

            TrackExceptionInfo();
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

        private void TrackExceptionInfo()
        {
            int i = 0;
            try
            {
                int j = 1 / i;
            }
            catch (DivideByZeroException ex)
            {
                AnalyticsService.TrackError(ex, new Dictionary<string, string>
                {
                    { "Method", "MainPageModel.TrackExceptionInfo()" }
                });

                throw;
            }
        }
    }
}
