using Asteroids_NeoWs_info.Models;
using Data.BrowseRest;
using Data.NeoFeedRest;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Asteroids_NeoWs_info.Views
{
    public partial class BrowseListPage : ContentPage
	{
        public BrowseListPage()
		{
			InitializeComponent ();
		}

		protected async override void OnAppearing ()
		{
			base.OnAppearing ();
            UpdateItemSource();
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
            List<BrowseData> BrowseDataList = await App.BrowseManager.GetTasksAsync();
            var asteroidsForBrowse = BrowseDataList[0].Near_earth_objects;
            listView.ItemsSource = asteroidsForBrowse;
        }

        async void UpdateItemSource()
        {
            List<BrowseData> BrowseDataList = await App.BrowseManager.GetTasksAsync();
            var asteroidsForBrowse = BrowseDataList[0].Near_earth_objects;
            listView.ItemsSource = asteroidsForBrowse;
        }
        async void OnGoItemClicked(object sender, EventArgs e)
        {
        }
        async void OnPrevItemClicked(object sender, EventArgs e)
        {
        }
        async void OnNextItemClicked(object sender, EventArgs e)
        {
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        }

    }
}
