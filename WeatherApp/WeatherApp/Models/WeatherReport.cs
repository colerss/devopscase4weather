using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public abstract class WeatherReport
    {
        [JsonPropertyName("dt")]
        public int Dt { get; set; }
        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
        [JsonPropertyName("wind_speed")]
        public float Wind_speed { get; set; }
        [JsonPropertyName("wind_deg")]
        public float Wind_deg { get; set; }
        [JsonPropertyName("clouds")]
        public int Clouds { get; set; }
        [JsonPropertyName("weather")]
        public WeatherState[] Weather { get; set; }

    }
}
