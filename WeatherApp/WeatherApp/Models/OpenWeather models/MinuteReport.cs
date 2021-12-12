using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class MinuteReport
    {
        [JsonPropertyName("dt")]
        public int Dt { get; set; }
        [JsonPropertyName("precipitation")]
        public int Precipitation { get; set; }
    }
}
