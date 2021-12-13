using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace WeatherApp.Models
{
    public class Country : IEquatable<Country>, IComparable<Country>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompareTo(Country other)
        {
            return Name.CompareTo(other.Name);
        }

        public bool Equals(Country other)
        {
            return Name == other.Name;
        }
    }
}
