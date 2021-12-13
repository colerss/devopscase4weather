using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class LocationProperties
    {
        [JsonPropertyName("locality")]
        public string City { get; set; }
        [JsonPropertyName("country")]
        public Country Country { get; set; }

        public string LocationString { get {return City + ", " + Country ; } }
    }
}
