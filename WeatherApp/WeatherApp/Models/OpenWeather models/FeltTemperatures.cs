using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class Temperatures
    {
        [JsonPropertyName("day")]
        public float Day { get; set; }
        
        [JsonPropertyName("night")]
        public float Night { get; set; }
        [JsonPropertyName("eve")]
        public float Eve { get; set; }
    }
}
