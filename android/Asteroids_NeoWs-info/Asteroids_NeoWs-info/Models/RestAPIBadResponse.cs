using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asteroids_NeoWs_info.Models
{
    internal class RestAPIBadResponse
    {
        [JsonProperty("code")]
        public string code { get; set; }
        [JsonProperty("http_error")]
        public string http_error { get; set; }
        [JsonProperty("error_message")]
        public string error_message { get; set; }
        [JsonProperty("request")]
        public string request { get; set; }
    }
}
