using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public static class ExtensionMethods
    {
        public static string UcFirst(this string str)
        {
            if (str.Length > 0)
            {
               str = Char.ToUpper(str[0]) + str.Substring(1);
            }
            else
            {
                str = str.ToUpper();
            }
            return str;
        }
    }
}
