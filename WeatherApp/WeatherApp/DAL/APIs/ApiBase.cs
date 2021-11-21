using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WeatherApp.APIs
{
    public class ApiBase
    {
        protected static readonly HttpClient _client = new HttpClient();
        protected string _apiKey;
        protected string _baseUrl;
        public ApiBase(string apiKey)
        {
            _apiKey = apiKey;
        }

    }
}
