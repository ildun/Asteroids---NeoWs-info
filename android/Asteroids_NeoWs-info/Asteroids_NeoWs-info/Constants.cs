using Xamarin.Essentials;
using Xamarin.Forms;

namespace Asteroids_NeoWs_info.Models
{
    public static class Constants
    {
        // URL of REST service
        public static string RestNeoFeedUrl = "https://api.nasa.gov/neo/rest/v1/feed{0}";
        public static string RestBrowseUrl = "https://api.nasa.gov/neo/rest/v1/neo/browse{0}";
    }
}
