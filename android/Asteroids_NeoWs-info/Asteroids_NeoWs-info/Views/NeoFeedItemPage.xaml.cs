using Asteroids_NeoWs_info.Models;
using System;
using Xamarin.Forms;

namespace Asteroids_NeoWs_info.Views
{
	public partial class NeoFeedItemPage : ContentPage
	{
		bool isNewItem;

		public NeoFeedItemPage(bool isNew = false)
		{
			InitializeComponent ();
			isNewItem = isNew;
		}

		

		async void OnCancelButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PopAsync ();
		}
	}
}
