using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asteroids_NeoWs_info.Models
{
    public class NeoFeedData
    {
        [JsonProperty("links")]
        public Links Links_m { get; set; }
        public class Links
        {
            [JsonProperty("next")]
            public string Next { get; set; }
            [JsonProperty("previous")]
            public string Previous { get; set; }
            [JsonProperty("self")]
            public string Self { get; set; }
        }
        [JsonProperty("element_count")]
        public uint Element_count { get; set; }

        [JsonProperty("near_earth_objects")]
        public Dictionary<string, List<Asteroid>> Near_earth_objects { get; set; }
    }
}
