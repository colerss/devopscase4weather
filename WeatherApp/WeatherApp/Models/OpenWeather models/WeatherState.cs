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
        [JsonPropertyName("icon")]
        public string IconRaw { get; set; }
        public string Icon { get
            {
                string isocode = "f004";
                switch (IconRaw)
                {
                    case "01d":
                        isocode = "\uf185";
                        break;
                    case "02d":
                        isocode = "\uf0c2";
                        break;
                    case "03d":
                        isocode = "\uf0c2";
                        break;
                    case "04d":
                        isocode = "\uf0c2";
                        break;
                    case "10d":
                        isocode = "\uf743";
                        break;
                    case "50d":
                        isocode = "\uf75f";
                        break;
                    case "01n":
                        isocode = "\uf186";
                        break;
                    case "02n":
                        isocode = "\uf0c2";
                        break;
                    case "03n":
                        isocode = "\uf0c2";
                        break;
                    case "04n":
                        isocode = "\uf0c2";
                        break;
                    case "10n":
                        isocode = "\uf73c";
                        break;
                    case "50n":
                        isocode = "\uf75f";
                        break;
                }
            
                return isocode;
            } }
        public string Readable { get {
                return Description.UcFirst(); 
            
            } }
    }
}
