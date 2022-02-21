using System;
using FreshMvvm;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using MsAppCenter.PageModels;
using MsAppCenter.Services.AnalyticsService;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MsAppCenter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Register service for dependency injection
            FreshIOC.Container.Register<IAnalyticsService, AppCenterAnalyticsService>();

            MainPage = new FreshNavigationContainer(
                FreshPageModelResolver.ResolvePageModel<MainPageModel>());
        }

        protected override void OnStart()
        {
            // MS AppCenter initialization
            // TODO: insert your secrets here
            AppCenter.Start("android={Your android App secret here};" +
                            "ios={Your iOS App secret here};",
                typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
