using Asteroids_NeoWs_info.Data;
using Asteroids_NeoWs_info.Services;
using Asteroids_NeoWs_info.Views;
using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asteroids_NeoWs_info
{
    public partial class App : Application
    {
        public static NeoFeedItemManager NeoFeedManager { get; private set; }
        public App()
        {
            
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            NeoFeedManager = new NeoFeedItemManager(new RestService());
            MainPage = new NavigationPage(new NeoFeedListPage());
            //MainPage = new AppShell();
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
