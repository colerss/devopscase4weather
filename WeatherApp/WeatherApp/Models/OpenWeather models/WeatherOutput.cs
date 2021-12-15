using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Media;
using System.Windows;

namespace WeatherApp.Models
{
    public class WeatherOutput
    {

        [JsonPropertyName("current")]
        public WeatherReportHourly Current { get; set; }
        [JsonPropertyName("hourly")]
        public WeatherReportHourly[] Hourly { get; set; }
        [JsonPropertyName("daily")]
        public WeatherReportDaily[] Daily { get; set; }

        public PointCollection TempPoints { get {
                PointCollection temp = new PointCollection();
                Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds -2;
                foreach (WeatherReportHourly hour in Hourly)
                {
                    temp.Add(new Point((hour.Dt - unixTimestamp) /1200 , Math.Round(hour.Temp, 3)/2 + 30 ));
                }
                return temp;
            
            } }
        public PointCollection RainPoints
        {
            get
            {
                PointCollection rain = new PointCollection();
                Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds - 2;
                foreach (WeatherReportHourly hour in Hourly)
                {
                    rain.Add(new Point((hour.Dt - unixTimestamp) / 1200, hour.Clouds / 4 + 1));
                }
                return rain;

            }
        }
    }
}
