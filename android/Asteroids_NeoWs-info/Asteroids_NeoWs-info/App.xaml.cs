﻿using Asteroids_NeoWs_info.Services;
using Asteroids_NeoWs_info.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asteroids_NeoWs_info
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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