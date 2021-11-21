using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.APIs;

namespace WeatherApp.ViewModels.MainViewModels
{
    public class DisplayViewModel : BasicViewModel
    {
        public override string this[string columnName] {
            get
            {
                return "";
            }
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "Refresh":
                    OpenWeatherMap weatherAPI = new OpenWeatherMap("a4c86f773df0a9b3fb2b9b49b203621f");
                    weatherAPI.GetWeather(51.16557f, 4.98917f);
                    break;
            }
        }
    }
}
