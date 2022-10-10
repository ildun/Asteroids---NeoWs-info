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


        async void UpdateItemSource()
        {
            List<BrowseData> BrowseDataList = await App.BrowseManager.GetTasksAsync();
            var asteroidsForBrowse = BrowseDataList[0].Near_earth_objects;
            listView.ItemsSource = asteroidsForBrowse;
        }
        async void OnGoItemClicked(object sender, EventArgs e)
        {
            int page;
            try
            {
                page = int.Parse(await DisplayPromptAsync("Page number", "Expected format: positive integer")) - 1;
            } catch (Exception ex)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("An error occured.", ex.Message, "OK");
                return;
            }
            if (page < 0)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("An error occured.", "Page number cannot be less then 1.", "OK");
                return;
            }
            BrowseRestService.UpdatePageParameter(page);
            UpdateItemSource();
        }
        async void OnPrevItemClicked(object sender, EventArgs e)
        {
            if(BrowseRestService.GetPageParameter() <= 0)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Alert", "You are already on the first page", "OK");
                BrowseRestService.UpdatePageParameter(0);
            }
            else
            {
                BrowseRestService.UpdatePageParameter(BrowseRestService.GetPageParameter()-1);
            }
            UpdateItemSource();
        }
        async void OnNextItemClicked(object sender, EventArgs e)
        {
            BrowseRestService.UpdatePageParameter(BrowseRestService.GetPageParameter() + 1);
            UpdateItemSource();
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        }

    }
}
