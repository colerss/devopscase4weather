﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class RealTemperatures : Temperatures
    {
        [JsonPropertyName("min")]
        public float Min { get; set; }
        [JsonPropertyName("max")]
        public float Max { get; set; }

    }
}
