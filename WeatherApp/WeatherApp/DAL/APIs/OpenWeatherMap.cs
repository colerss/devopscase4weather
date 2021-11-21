using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.APIs
{
    public class OpenWeatherMap : ApiBase
    {
        public OpenWeatherMap(string apiKey) : base(apiKey)
        {
            _baseUrl = "https://api.openweathermap.org/data/2.5";
        }
    }
}
