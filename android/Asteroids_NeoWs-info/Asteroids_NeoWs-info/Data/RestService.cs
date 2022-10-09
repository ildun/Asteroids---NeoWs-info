using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Asteroids_NeoWs_info.Models;
using Newtonsoft.Json;

namespace Asteroids_NeoWs_info.Data
{
    public class RestService : IRestService
    {
        HttpClient client;
        //JsonSerializerOptions serializerOptions;

        public List<NeoFeed> NeoFeedField { get; private set; }

        public RestService()
        {
            client = new HttpClient();
            /*serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            */
        }

        public async Task<List<NeoFeed>> RefreshDataAsync()
        {
            //NeoFeedField = new NeoFeed();

            //Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
            string apiKey = Secrets.API__KEY;
            Uri uri = new Uri(string.Format(Constants.RestUrl, "?start_date=2022-10-02&end_date=2022-10-09&api_key=" + apiKey));
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    NeoFeedField = new List<NeoFeed> { JsonConvert.DeserializeObject<NeoFeed>(content) };
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return NeoFeedField;
        }

    }
}
