using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class GeocodeOutput
    {
        [JsonPropertyName("features")]
        public Location[] LocationArr { get; set; }

        public Location Location { get { return LocationArr[0]; } }
    }
}
