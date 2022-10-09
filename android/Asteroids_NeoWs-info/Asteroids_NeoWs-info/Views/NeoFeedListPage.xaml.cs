using Asteroids_NeoWs_info.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            //listView.ItemsSource = await App.NeoFeedManager.GetTasksAsync ();
            List<NeoFeed> NeoFeedList = await App.NeoFeedManager.GetTasksAsync();
            var asteroidsDictionary = NeoFeedList[0].Near_earth_objects;
            var asteroidsLists = asteroidsDictionary.Values;
            IEnumerable<Asteroid> AllAsteroids =new List<Asteroid>();
            foreach (var asteroids in asteroidsLists.AsEnumerable()) {
                AllAsteroids = AllAsteroids.Concat (asteroids);
            }
            listView.ItemsSource = AllAsteroids.ToList();
            //ObservableCollection<Asteroid> asteroids = new ObservableCollection<Asteroid>();
            //listView.ItemsSource = (await App.NeoFeedManager.GetTasksAsync()).AsEnumera; ;

            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

		async void OnAddItemClicked (object sender, EventArgs e)
		{
            
			//NeoFeed neoFeed = (NeoFeed)sender;
            //await DisplayAlert("neoFeed", "neoFeed", "OK");
            /*
            await Navigation.PushAsync(new NeoFeedItemPage(true)
            {
                BindingContext = new NeoFeed
                {
                    ID = Guid.NewGuid().ToString()
                }
            });
			*/
        }

		async void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
            NeoFeed neoFeed = (NeoFeed)e.SelectedItem;
            string date = "2022-10-09";
            List<Asteroid> listOfAsteroid;
            neoFeed.Near_earth_objects.TryGetValue(date, out listOfAsteroid);
            await DisplayAlert("Element count: " + neoFeed.Element_count, listOfAsteroid[0].Name, "OK");
            /*
            await Navigation.PushAsync(new TodoItemPage
            {
                BindingContext = e.SelectedItem as TodoItem
            });
			*/
        }
	}
}
