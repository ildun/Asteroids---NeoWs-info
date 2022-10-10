using Newtonsoft.Json;
using System.Collections.Generic;


namespace Asteroids_NeoWs_info.Models
{
    public class BrowseData
    {
        [JsonProperty("links")]
        public Links Links_m { get; set; }
        public class Links
        {
            [JsonProperty("next")]
            public string Next { get; set; }
            [JsonProperty("prev")]
            public string Previous { get; set; }
            [JsonProperty("self")]
            public string Self { get; set; }
        }

        [JsonProperty("page")]
        public BrowseDataPage Page { get; set; }
        public class BrowseDataPage
        {
            [JsonProperty("size")]
            public int Size { get; set; }
            [JsonProperty("total_elements")]
            public int Total_elements { get; set; }
            [JsonProperty("total_pages")]
            public int Total_pages { get; set; }
            [JsonProperty("number")]
            public int Number { get; set; }
        }
        [JsonProperty("element_count")]
        public uint Element_count { get; set; }

        [JsonProperty("near_earth_objects")]
        public List<AsteroidForBrowse> Near_earth_objects { get; set; }
    }
}
