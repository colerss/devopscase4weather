using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WeatherApp.ViewModels.MainViewModels;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //Initializing Messenger service to create message boxes withotu breaking mvvm
            Messenger.Default.Register<string>(this, ShowMessage);
            DisplayViewModel viewModel = new DisplayViewModel();
            Views.DisplayView view = new Views.DisplayView();
            view.DataContext = viewModel;
            view.Show();
        }


        private void ShowMessage(string message) => MessageBox.Show(message);
    }
}
