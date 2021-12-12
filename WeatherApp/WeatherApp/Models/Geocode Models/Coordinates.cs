using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class Geometry
    {
        [JsonPropertyName("coordinates")]
        public float[] Coordinates { get; set; }


        public float Longitude { get { return Coordinates[0]; } }
        public float Latitude { get { return Coordinates[1]; } }
    }
}
