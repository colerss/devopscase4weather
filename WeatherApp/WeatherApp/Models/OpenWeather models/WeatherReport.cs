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

        public WeatherState WeatherState { get
            {
                return Weather[0];
            } }
        public DateTime Datetime { get {
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(Dt).ToLocalTime();
                return dtDateTime;
                 } }

        public string DayOfWeek
        {
            get
            {
                return Datetime.DayOfWeek.ToString();
            }
        }
    }
}
