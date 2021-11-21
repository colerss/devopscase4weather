using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.APIs
{
    public class OpenWeatherMap : ApiBase
    {
        private string _units = "metric";
        private string _lang = "en";
        public OpenWeatherMap(string apiKey) : base(apiKey)
        {
            _baseUrl = "https://api.openweathermap.org/data/2.5";
        }

        public WeatherOutput GetWeather(float latitude, float longitude)
        {
            WeatherOutput output = new WeatherOutput();

            string apiString = string.Format("{0}/onecall?lat={1}&lon={2}&appid={3}&units={4}&lang={5}", 
                _baseUrl, latitude, longitude, _apiKey, _units, _baseUrl);
            HttpResponseMessage response =  _client.SendAsync(new HttpRequestMessage(HttpMethod.Get, apiString)).Result;

            return output;
        }
    }
}
