using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class WeatherState
    {
        [JsonPropertyName("main")]
        public string Main { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }

        public string Icon { get
            {
                return "Sun";
            } }
        public string Readable { get {
                return Description.UcFirst(); 
            
            } }
    }
}
