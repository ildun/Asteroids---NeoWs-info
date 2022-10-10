using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Asteroids_NeoWs_info.Data;
using Asteroids_NeoWs_info.Models;
using Newtonsoft.Json;

namespace Data.NeoFeedRest
{
    public class NeoFeedRestService : INeoFeedRestService
    {
        HttpClient client;

        private static string startDateParam = "";
        private static string endDateParam = "";
        public static void UpdateStartDateParameter(string startDate)
        {
            startDateParam = startDate;
        }
        public static void UpdateEndDateParameter(string endDate)
        {
            endDateParam = endDate;
        }
        public List<NeoFeedData> NeoFeedField { get; private set; }

        public NeoFeedRestService()
        {
            client = new HttpClient();
        }

        public async Task<List<NeoFeedData>> RefreshDataAsync()
        {
            string apiKey = Secrets.API__KEY;
            Uri uri = new Uri(string.Format(Constants.RestNeoFeedUrl, "?start_date=" + startDateParam + "&end_date=" + endDateParam + "&api_key=" + apiKey));
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                string content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    NeoFeedField = new List<NeoFeedData> { JsonConvert.DeserializeObject<NeoFeedData>(content) };
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

            return NeoFeedField;
        }

    }
}
