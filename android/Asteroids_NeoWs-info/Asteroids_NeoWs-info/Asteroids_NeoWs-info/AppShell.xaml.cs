using Asteroids_NeoWs_info.ViewModels;
using Asteroids_NeoWs_info.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Asteroids_NeoWs_info
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
