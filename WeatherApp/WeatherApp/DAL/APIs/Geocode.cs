using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.APIs
{
    public class Geocode : ApiBase
    {
        public Geocode(string apiKey) : base(apiKey)
        {
            _baseUrl = "https://app.geocodeapi.io/api/v1";
        }
    }
}
