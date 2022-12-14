using Asteroids_NeoWs_info.Models;
using Data.BrowseRest;
using Data.NeoFeedRest;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Asteroids_NeoWs_info.Views
{
    public partial class NeoFeedListPage : ContentPage
	{
        public NeoFeedListPage()
		{
			InitializeComponent ();
		}

		protected async override void OnAppearing ()
		{
			base.OnAppearing ();
        }

        async void OnEditItemClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Edit parameter:", "Cancel", null, "start date", "end date");
            switch (action)
            {
                case "Cancel":
                    return;
                case "start date":
                    NeoFeedRestService.UpdateStartDateParameter( await DisplayPromptAsync("Start date for request", "Expected format (yyyy-mm-dd)"));
                    return;
                case "end date":
                    NeoFeedRestService.UpdateEndDateParameter( await DisplayPromptAsync("End date for request", "Expected format (yyyy-mm-dd)"));
                    return;
            }
        }
        async void OnSendItemClicked(object sender, EventArgs e)
		{
            List<NeoFeedData> NeoFeedList = await App.NeoFeedManager.GetTasksAsync();
            var asteroidsDictionary = NeoFeedList[0].Near_earth_objects;
            var asteroidsLists = asteroidsDictionary.Values;
            IEnumerable<Asteroid> AllAsteroids = new List<Asteroid>();
            foreach (var asteroids in asteroidsLists.AsEnumerable())
            {
                AllAsteroids = AllAsteroids.Concat(asteroids);
            }
            listView.ItemsSource = AllAsteroids.ToList();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        }

    }
}
