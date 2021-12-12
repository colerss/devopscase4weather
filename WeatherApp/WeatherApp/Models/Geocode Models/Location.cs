using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class Location
    {
        [JsonPropertyName("geometry")]
        public Geometry Geometry { get; set; }
        
        [JsonPropertyName("properties")]
        public LocationProperties Properties { get; set; }

        
    }
}
