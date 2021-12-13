using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class WeatherReportHourly : WeatherReport
    {
        [JsonPropertyName("temp")]
        public float Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public float FeelsLike { get; set; }

        public string TempString { get {
                return Temp + " °C";
            } }
    }
}
