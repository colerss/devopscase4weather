using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class WeatherReportDaily : WeatherReport
    {
        [JsonPropertyName("temp")]
        public RealTemperatures Temp { get; set; }
        [JsonPropertyName("feels_like")]
        public Temperatures FeltTemp { get; set; }
    }
}
