using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WeatherApp.ViewModels
{
    public abstract class BasicViewModel : INotifyPropertyChanged, ICommand, IDataErrorInfo
    {

        #region Startup routine
        public BasicViewModel()
        {
            this.CloseWindowCommand = new RelayCommand<Window>(this.CloseWindow);
        }

        public RelayCommand<Window> CloseWindowCommand { get; private set; }
        //MVVM Light implementation, allows us to close windows without breaking the MVVM pattern

        private void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
        #endregion
        public static void ErrorLogging(Exception ex)
        {
            //Allows us to log all errors
            string strPath = @"Log.txt";
            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("Error: " + ex.GetType().Name);
                sw.WriteLine("InnerException: " + ex.InnerException);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("===========End============= " + DateTime.Now);

            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region IDataErrorInfo
        public abstract string this[string columnName] { get; }

        public bool isValid()
        {
            return string.IsNullOrEmpty(Error);
        }
        public string Error
        {
            get
            {
                string foutmeldingen = "";
                foreach (var item in this.GetType().GetProperties(BindingFlags.Instance))
                {
                    string fout = this[item.Name];
                    if (!string.IsNullOrWhiteSpace(fout))
                    {
                        foutmeldingen += fout + Environment.NewLine;
                    }
                }
                return foutmeldingen;
            }
        }

        #endregion
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
