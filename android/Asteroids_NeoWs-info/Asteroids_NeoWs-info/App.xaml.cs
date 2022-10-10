using Asteroids_NeoWs_info.Data;
using Data.BrowseRest;
using Data.NeoFeedRest;
using Xamarin.Forms;


namespace Asteroids_NeoWs_info
{
    public partial class App : Application
    {
        public static NeoFeedItemManager NeoFeedManager { get; private set; }
        public static BrowseItemManager BrowseManager { get; private set; }
        public App()
        {
            
            InitializeComponent();
            
            NeoFeedManager = new NeoFeedItemManager(new NeoFeedRestService());
            BrowseManager = new BrowseItemManager(new BrowseRestService());

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
