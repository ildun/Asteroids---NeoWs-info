using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Asteroids_NeoWs_info.Data;
using Asteroids_NeoWs_info.Models;
using Newtonsoft.Json;

namespace Data.BrowseRest
{
    public class BrowseRestService : IBrowseRestService
    {
        HttpClient client;

        private static int pageParam = 0;
        private const string sizeParam = "10";
        public static void UpdatePageParameter(int startDate)
        {
            pageParam = startDate;
        }
        public static int GetPageParameter()
        {
            return pageParam;
        }
        public List<BrowseData> BrowseField { get; private set; }

        public BrowseRestService()
        {
            client = new HttpClient();
        }


        public async Task<List<BrowseData>> RefreshDataAsync()
        {
            string apiKey = Secrets.API__KEY;
            Uri uri = new Uri(string.Format(Constants.RestBrowseUrl, "?page=" + pageParam + "&size=" + sizeParam + "&api_key=" + apiKey));
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                string content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    BrowseField = new List<BrowseData> { JsonConvert.DeserializeObject<BrowseData>(content) };
                }
                else
                {
                    string errorMsg = JsonConvert.DeserializeObject<RestAPIBadResponse>(content).error_message;
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Response was not successful", errorMsg, "OK");
                }
            }
            catch (Exception ex)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Unexpected error", ex.Message, "OK");
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return BrowseField;
        }

    }
}
