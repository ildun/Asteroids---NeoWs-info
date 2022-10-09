using Asteroids_NeoWs_info.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Asteroids_NeoWs_info.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}