using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WeatherApp.APIs;
using WeatherApp.DAL.Repositories;
using WeatherApp.Models;

namespace WeatherApp.ViewModels.MainViewModels
{
    public class DisplayViewModel : BasicViewModel
    {
        private Geocode geoapi;
        private OpenWeatherMap weatherapi;
        private Location lastLocation;
        private WeatherOutput lastWeather;
        private LocationProperties locationData;
        private ObservableCollection<Country> countries;
        CountryRepository countryRepository = new CountryRepository();
        public ObservableCollection<Country> Countries { get { return countries; }
            set {
                countries = value;
                NotifyPropertyChanged();
            }
        }
        public LocationProperties LocationData { get { return locationData; }
            set
            {
                locationData = value;
                NotifyPropertyChanged();
            }
        }

        public WeatherOutput WeatherReport { get { return lastWeather; }
            set
            {
                lastWeather = value;
                NotifyPropertyChanged();
            }
        }
        public override string this[string columnName] {
            get
            {
                return "";
            }
        }

        public DisplayViewModel() : base(){
            geoapi = new Geocode("49a4e290-2b26-11eb-826a-c9828c7a9b67");
            weatherapi = new OpenWeatherMap("a4c86f773df0a9b3fb2b9b49b203621f");
            LocationData = new LocationProperties();
            Countries = new ObservableCollection<Country>(countryRepository.GetCountries());
            LocationData.City = "Geel";
            LocationData.Country = Countries.Where(x => x.Name == "Belgium").FirstOrDefault();
            InitializeApi();
        }

        private async void InitializeApi()
        {
            lastLocation =  (await geoapi.GetLocationByName(LocationData.City, LocationData.Country.Name)).Location;
            WeatherReport = await weatherapi.GetWeather(lastLocation.Geometry.Latitude, lastLocation.Geometry.Longitude);
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override async void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "Refresh":
                    lastLocation = (await geoapi.GetLocationByName(LocationData.City, LocationData.Country.Name)).Location;
                    WeatherReport = await weatherapi.GetWeather(lastLocation.Geometry.Latitude, lastLocation.Geometry.Longitude);
                    break;
            }
        }
    }
}
