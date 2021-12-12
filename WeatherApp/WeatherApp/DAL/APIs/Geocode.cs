using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.APIs
{
    public class Geocode : ApiBase
    {
        public Geocode(string apiKey) : base(apiKey)
        {
            _baseUrl = "https://app.geocodeapi.io/api/v1";
        }

        public async Task<GeocodeOutput> GetLocationByName(string city, string country)
        {
            GeocodeOutput output = new GeocodeOutput();
            string apiString = string.Format("{0}/search?apikey={1}&text='{2}, {3}'",
               _baseUrl, _apiKey, city, country);
            HttpResponseMessage response = await _client.SendAsync(new HttpRequestMessage(HttpMethod.Get, apiString));
            using (var reader = new StreamReader(await response.Content.ReadAsStreamAsync()))
            {
                output = JsonSerializer.Deserialize<GeocodeOutput>(reader.ReadToEnd());
            }
            return output;
        }
    }
}
