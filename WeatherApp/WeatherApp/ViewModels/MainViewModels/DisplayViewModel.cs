using System;
using System.Collections.Generic;
using System.Text;

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
            switch (parameter.ToString())
            {
                
            }
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {

            }
        }
    }
}
