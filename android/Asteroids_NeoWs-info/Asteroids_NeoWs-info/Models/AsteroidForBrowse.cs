using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms.Shapes;

namespace Asteroids_NeoWs_info.Models
{
    public class AsteroidForBrowse
    {
        [JsonProperty("links")]
        public Links Links_m { get; set; }
        public class Links
        {
            [JsonProperty("self")]
            public string Self { get; set; }
        }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("neo_reference_id")]
        public string Neo_reference_id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("name_limited")]
        public string Name_limited { get; set; }
        [JsonProperty("designation")]
        public string Designation { get; set; }
        [JsonProperty("absolute_magnitude_h")]
        public double Absolute_magnitude_h { get; set; }
        [JsonProperty("estimated_diameter")]
        public Estimated_diameter_measurements Estimated_diameter { get; set; }
        
        public class Estimated_diameter_measurements
        {
            [JsonProperty("kilometers")]
            public Estimated_diameter Kilometers { get; set; }
            [JsonProperty("meters")]
            public Estimated_diameter Meters { get; set; }
            [JsonProperty("miles")]
            public Estimated_diameter Miles { get; set; }
            [JsonProperty("feet")]
            public Estimated_diameter Feet { get; set; }

            public class Estimated_diameter
            {

                [JsonProperty("estimated_diameter_min")]
                public decimal Estimated_diameter_min { get; set; }
                [JsonProperty("estimated_diameter_max")]
                public decimal Estimated_diameter_max { get; set; }
            }
        }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool Is_potentially_hazardous_asteroid { get; set; }
        [JsonProperty("close_approach_data")]
        public List<Close_approach_data> Close_approach_data_list { get; set; }
        public class Close_approach_data
        {
            [JsonProperty("close_approach_date")]
            public string Close_approach_date { get; set; }
            [JsonProperty("close_approach_date_full")]
            public string Close_approach_date_full { get; set; }
            [JsonProperty("epoch_date_close_approach")]
            public long Epoch_date_close_approach { get; set; }
            [JsonProperty("relative_velocity")]
            public Relative_velocity Relative_velocity_m { get; set; }
            public class Relative_velocity
            {

                [JsonProperty("kilometers_per_second")]
                public decimal Kilometers_per_second { get; set; }
                [JsonProperty("kilometers_per_hour")]
                public decimal Kilometers_per_hour { get; set; }
                [JsonProperty("miles_per_hour")]
                public decimal Miles_per_hour { get; set; }
            }

            [JsonProperty("miss_distance")]
            public Miss_distance Miss_distance_m { get; set; }
            public class Miss_distance
            {

                [JsonProperty("astronomical")]
                public decimal Astronomical { get; set; }
                [JsonProperty("lunar")]
                public decimal Lunar { get; set; }
                [JsonProperty("kilometers")]
                public decimal Kilometers { get; set; }
                [JsonProperty("miles")]
                public decimal Miles { get; set; }
            }
            [JsonProperty("orbiting_body")]
            public string Orbiting_body { get; set; }
        }
        [JsonProperty("orbital_data")]
        public OrbitalData Orbital_data { get; set; }
        public class OrbitalData
        {

            [JsonProperty("orbit_id")]
            public string Orbit_id { get; set; }
            [JsonProperty("orbit_determination_date")]
            public string Orbit_determination_date { get; set; }
            [JsonProperty("first_observation_date")]
            public string First_observation_date { get; set; }
            [JsonProperty("last_observation_date")]
            public string Lirst_observation_date { get; set; }
            [JsonProperty("data_arc_in_days")]
            public int Data_arc_in_days { get; set; }
            [JsonProperty("observations_used")]
            public int Observations_used { get; set; }
            [JsonProperty("orbit_uncertainty")]
            public string Orbit_uncertainty { get; set; }
            [JsonProperty("minimum_orbit_intersection")]
            public string Minimum_orbit_intersection { get; set; }
            [JsonProperty("jupiter_tisserand_invariant")]
            public string Jupiter_tisserand_invariant { get; set; }
            [JsonProperty("epoch_osculation")]
            public string Epoch_osculation { get; set; }
            [JsonProperty("eccentricity")]
            public string Eccentricity { get; set; }
            [JsonProperty("semi_major_axis")]
            public string Semi_major_axis { get; set; }
            [JsonProperty("inclination")]
            public string Inclination { get; set; }
            [JsonProperty("ascending_node_longitude")]
            public string Ascending_node_longitude { get; set; }
            [JsonProperty("orbital_period")]
            public string Orbital_period { get; set; }
            [JsonProperty("perihelion_distance")]
            public string Perihelion_distance { get; set; }
            [JsonProperty("perihelion_argument")]
            public string Perihelion_argument { get; set; }
            [JsonProperty("aphelion_distance")]
            public string Aphelion_distance { get; set; }
            [JsonProperty("perihelion_time")]
            public string Perihelion_time { get; set; }
            [JsonProperty("mean_anomaly")]
            public string Mean_anomaly { get; set; }
            [JsonProperty("mean_motion")]
            public string Mean_motion { get; set; }
            [JsonProperty("equinox")]
            public string Equinox { get; set; }
            [JsonProperty("orbit_class")]
            public OrbitClass Orbit_class { get; set; }
            public class OrbitClass
            {
                [JsonProperty("orbit_class_type")]
                public string Orbit_class_type { get; set; }
                [JsonProperty("orbit_class_range")]
                public string Orbit_class_range { get; set; }
                [JsonProperty("orbit_class_description")]
                public string Orbit_class_description { get; set; }
            }
        }

        [JsonProperty("is_sentry_object")]
        public bool Is_sentry_object { get; set; }
    }
}
