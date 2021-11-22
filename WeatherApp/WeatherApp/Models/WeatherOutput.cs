using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class WeatherOutput
    {

        [JsonPropertyName("current")]
        public WeatherReportHourly Current { get; set; }
        [JsonPropertyName("minutely")]
        public MinuteReport[] Minutely { get; set; }
        [JsonPropertyName("hourly")]
        public WeatherReportHourly[] Hourly { get; set; }
        [JsonPropertyName("daily")]
        public WeatherReportDaily[] Daily { get; set; }
    }
}
