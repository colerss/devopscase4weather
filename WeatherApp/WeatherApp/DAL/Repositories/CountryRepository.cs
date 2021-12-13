using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Models;
using Dapper;
using Microsoft.Data.Sqlite;


namespace WeatherApp.DAL.Repositories
{
    class CountryRepository : SqlBaseRepository
    {

        public CountryRepository()
        {
            if (!DatabaseExists())
            {
                CreateDatabase();
                InsertAllCountries();
            }
        }
        public int InsertCountry(Country country)
        {
            string sql = "INSERT INTO Countries ( Name) Values (@Name);";

            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                return connection.Execute(sql, country);
            }
        }

        public int DeleteCountry(string countryname)
        {
            string sql = "DELETE FROM Countries WHERE Name = @Name;";

            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                return connection.Execute(sql, new { CountryName = countryname });
            }
        }

        public IEnumerable<Country> GetCountries()
        {
            string sql = "SELECT * FROM Countries;";

            using (var connection = DbConnectionFactory())
            {
                return connection.Query<Country>(sql);
            }
        }

        public int InsertAllCountries()
        {
            string sql = "INSERT INTO Countries(Name) VALUES('Afghanistan');" +
                "INSERT INTO Countries(Name) VALUES('Albania')" +
            "Insert INTO Countries(Name) VALUES('Algeria');" +
            "Insert INTO Countries(Name) VALUES('Andorra');" +
            "Insert INTO Countries(Name) VALUES('Angola');" +
            "Insert INTO Countries(Name) VALUES('Anguilla');" +
            "Insert INTO Countries(Name) VALUES('Antigua & Barbuda');" +
            "Insert INTO Countries(Name) VALUES('Argentina');" +
            "Insert INTO Countries(Name) VALUES('Armenia');" +
            "Insert INTO Countries(Name) VALUES('Australia');" +
            "Insert INTO Countries(Name) VALUES('Austria');" +
            "Insert INTO Countries(Name) VALUES('Azerbaijan');" +
            "Insert INTO Countries(Name) VALUES('Bahamas');" +
            "Insert INTO Countries(Name) VALUES('Bahrain');" +
            "Insert INTO Countries(Name) VALUES('Bangladesh');" +
            "Insert INTO Countries(Name) VALUES('Barbados');" +
            "Insert INTO Countries(Name) VALUES('Belarus');" +
            "Insert INTO Countries(Name) VALUES('Belgium');" +
            "Insert INTO Countries(Name) VALUES('Belize');" +
            "Insert INTO Countries(Name) VALUES('Benin');" +
            "Insert INTO Countries(Name) VALUES('Bermuda');" +
            "Insert INTO Countries(Name) VALUES('Bhutan');" +
            "Insert INTO Countries(Name) VALUES('Bolivia');" +
            "Insert INTO Countries(Name) VALUES('Bosnia & Herzegovina');" +
            "Insert INTO Countries(Name) VALUES('Botswana');" +
            "Insert INTO Countries(Name) VALUES('Brazil');" +
            "Insert INTO Countries(Name) VALUES('Brunei Darussalam');" +
            "Insert INTO Countries(Name) VALUES('Bulgaria');" +
            "Insert INTO Countries(Name) VALUES('Burkina Faso');" +
            "Insert INTO Countries(Name) VALUES('Myanmar/Burma');" +
            "Insert INTO Countries(Name) VALUES('Burundi');" +
            "Insert INTO Countries(Name) VALUES('Cambodia');" +
            "Insert INTO Countries(Name) VALUES('Cameroon');" +
            "Insert INTO Countries(Name) VALUES('Canada');" +
            "Insert INTO Countries(Name) VALUES('Cape Verde');" +
            "Insert INTO Countries(Name) VALUES('Cayman Islands');" +
            "Insert INTO Countries(Name) VALUES('Central African Republic');" +
            "Insert INTO Countries(Name) VALUES('Chad');" +
            "Insert INTO Countries(Name) VALUES('Chile');" +
            "Insert INTO Countries(Name) VALUES('China');" +
            "Insert INTO Countries(Name) VALUES('Colombia');" +
            "Insert INTO Countries(Name) VALUES('Comoros');" +
            "Insert INTO Countries(Name) VALUES('Congo');" +
            "Insert INTO Countries(Name) VALUES('Costa Rica');" +
            "Insert INTO Countries(Name) VALUES('Croatia');" +
            "Insert INTO Countries(Name) VALUES('Cuba');" +
            "Insert INTO Countries(Name) VALUES('Cyprus');" +
            "Insert INTO Countries(Name) VALUES('Czech Republic');" +
            "Insert INTO Countries(Name) VALUES('Democratic Republic of the Congo');" +
            "Insert INTO Countries(Name) VALUES('Denmark');" +
            "Insert INTO Countries(Name) VALUES('Djibouti');" +
            "Insert INTO Countries(Name) VALUES('Dominican Republic');" +
            "Insert INTO Countries(Name) VALUES('Dominica');" +
            "Insert INTO Countries(Name) VALUES('Ecuador');" +
            "Insert INTO Countries(Name) VALUES('Egypt');" +
            "Insert INTO Countries(Name) VALUES('El Salvador');" +
            "Insert INTO Countries(Name) VALUES('Equatorial Guinea');" +
            "Insert INTO Countries(Name) VALUES('Eritrea');" +
            "Insert INTO Countries(Name) VALUES('Estonia');" +
            "Insert INTO Countries(Name) VALUES('Ethiopia');" +
            "Insert INTO Countries(Name) VALUES('Fiji');" +
            "Insert INTO Countries(Name) VALUES('Finland');" +
            "Insert INTO Countries(Name) VALUES('France');" +
            "Insert INTO Countries(Name) VALUES('French Guiana');" +
            "Insert INTO Countries(Name) VALUES('Gabon');" +
            "Insert INTO Countries(Name) VALUES('Gambia');" +
            "Insert INTO Countries(Name) VALUES('Georgia');" +
            "Insert INTO Countries(Name) VALUES('Germany');" +
            "Insert INTO Countries(Name) VALUES('Ghana');" +
            "Insert INTO Countries(Name) VALUES('Great Britain');" +
            "Insert INTO Countries(Name) VALUES('Greece');" +
            "Insert INTO Countries(Name) VALUES('Grenada');" +
            "Insert INTO Countries(Name) VALUES('Guadeloupe');" +
            "Insert INTO Countries(Name) VALUES('Guatemala');" +
            "Insert INTO Countries(Name) VALUES('Guinea');" +
            "Insert INTO Countries(Name) VALUES('Guinea-Bissau');" +
            "Insert INTO Countries(Name) VALUES('Guyana');" +
            "Insert INTO Countries(Name) VALUES('Haiti');" +
            "Insert INTO Countries(Name) VALUES('Honduras');" +
            "Insert INTO Countries(Name) VALUES('Hungary');" +
            "Insert INTO Countries(Name) VALUES('Iceland');" +
            "Insert INTO Countries(Name) VALUES('India');" +
            "Insert INTO Countries(Name) VALUES('Indonesia');" +
            "Insert INTO Countries(Name) VALUES('Iran');" +
            "Insert INTO Countries(Name) VALUES('Iraq');" +
            "Insert INTO Countries(Name) VALUES('Israel and the Occupied Territories');" +
            "Insert INTO Countries(Name) VALUES('Italy');" +
            "Insert INTO Countries(Name) VALUES('Ivory Coast (Cote d''Ivoire)');" +
            "Insert INTO Countries(Name) VALUES('Jamaica');" +
            "Insert INTO Countries(Name) VALUES('Japan');" +
            "Insert INTO Countries(Name) VALUES('Jordan');" +
            "Insert INTO Countries(Name) VALUES('Kazakhstan');" +
            "Insert INTO Countries(Name) VALUES('Kenya');" +
            "Insert INTO Countries(Name) VALUES('Kosovo');" +
            "Insert INTO Countries(Name) VALUES('Kuwait');" +
            "Insert INTO Countries(Name) VALUES('Kyrgyz Republic (Kyrgyzstan)');" +
            "Insert INTO Countries(Name) VALUES('Laos');" +
            "Insert INTO Countries(Name) VALUES('Latvia');" +
            "Insert INTO Countries(Name) VALUES('Lebanon');" +
            "Insert INTO Countries(Name) VALUES('Lesotho');" +
            "Insert INTO Countries(Name) VALUES('Liberia');" +
            "Insert INTO Countries(Name) VALUES('Libya');" +
            "Insert INTO Countries(Name) VALUES('Liechtenstein');" +
            "Insert INTO Countries(Name) VALUES('Lithuania');" +
            "Insert INTO Countries(Name) VALUES('Luxembourg');" +
            "Insert INTO Countries(Name) VALUES('Republic of Macedonia');" +
            "Insert INTO Countries(Name) VALUES('Madagascar');" +
            "Insert INTO Countries(Name) VALUES('Malawi');" +
            "Insert INTO Countries(Name) VALUES('Malaysia');" +
            "Insert INTO Countries(Name) VALUES('Maldives');" +
            "Insert INTO Countries(Name) VALUES('Mali');" +
            "Insert INTO Countries(Name) VALUES('Malta');" +
            "Insert INTO Countries(Name) VALUES('Martinique');" +
            "Insert INTO Countries(Name) VALUES('Mauritania');" +
            "Insert INTO Countries(Name) VALUES('Mauritius');" +
            "Insert INTO Countries(Name) VALUES('Mayotte');" +
            "Insert INTO Countries(Name) VALUES('Mexico');" +
            "Insert INTO Countries(Name) VALUES('Moldova, Republic of');" +
            "Insert INTO Countries(Name) VALUES('Monaco');" +
            "Insert INTO Countries(Name) VALUES('Mongolia');" +
            "Insert INTO Countries(Name) VALUES('Montenegro');" +
            "Insert INTO Countries(Name) VALUES('Montserrat');" +
            "Insert INTO Countries(Name) VALUES('Morocco');" +
            "Insert INTO Countries(Name) VALUES('Mozambique');" +
            "Insert INTO Countries(Name) VALUES('Namibia');" +
            "Insert INTO Countries(Name) VALUES('Nepal');" +
            "Insert INTO Countries(Name) VALUES('Netherlands');" +
            "Insert INTO Countries(Name) VALUES('New Zealand');" +
            "Insert INTO Countries(Name) VALUES('Nicaragua');" +
            "Insert INTO Countries(Name) VALUES('Niger');" +
            "Insert INTO Countries(Name) VALUES('Nigeria');" +
            "Insert INTO Countries(Name) VALUES('Korea, Democratic Republic of (North Korea)');" +
            "Insert INTO Countries(Name) VALUES('Norway');" +
            "Insert INTO Countries(Name) VALUES('Oman');" +
            "Insert INTO Countries(Name) VALUES('Pacific Islands');" +
            "Insert INTO Countries(Name) VALUES('Pakistan');" +
            "Insert INTO Countries(Name) VALUES('Panama');" +
            "Insert INTO Countries(Name) VALUES('Papua New Guinea');" +
            "Insert INTO Countries(Name) VALUES('Paraguay');" +
            "Insert INTO Countries(Name) VALUES('Peru');" +
            "Insert INTO Countries(Name) VALUES('Philippines');" +
            "Insert INTO Countries(Name) VALUES('Poland');" +
            "Insert INTO Countries(Name) VALUES('Portugal');" +
            "Insert INTO Countries(Name) VALUES('Puerto Rico');" +
            "Insert INTO Countries(Name) VALUES('Qatar');" +
            "Insert INTO Countries(Name) VALUES('Reunion');" +
            "Insert INTO Countries(Name) VALUES('Romania');" +
            "Insert INTO Countries(Name) VALUES('Russian Federation');" +
            "Insert INTO Countries(Name) VALUES('Rwanda');" +
            "Insert INTO Countries(Name) VALUES('Saint Kitts and Nevis');" +
            "Insert INTO Countries(Name) VALUES('Saint Lucia');" +
            "Insert INTO Countries(Name) VALUES('Saint Vincent''s & Grenadines');" +
            "Insert INTO Countries(Name) VALUES('Samoa');" +
            "Insert INTO Countries(Name) VALUES('Sao Tome and Principe');" +
            "Insert INTO Countries(Name) VALUES('Saudi Arabia');" +
            "Insert INTO Countries(Name) VALUES('Senegal');" +
            "Insert INTO Countries(Name) VALUES('Serbia');" +
            "Insert INTO Countries(Name) VALUES('Seychelles');" +
            "Insert INTO Countries(Name) VALUES('Sierra Leone');" +
            "Insert INTO Countries(Name) VALUES('Singapore');" +
            "Insert INTO Countries(Name) VALUES('Slovak Republic (Slovakia)');" +
            "Insert INTO Countries(Name) VALUES('Slovenia');" +
            "Insert INTO Countries(Name) VALUES('Solomon Islands');" +
            "Insert INTO Countries(Name) VALUES('Somalia');" +
            "Insert INTO Countries(Name) VALUES('South Africa');" +
            "Insert INTO Countries(Name) VALUES('Korea, Republic of (South Korea)');" +
            "Insert INTO Countries(Name) VALUES('South Sudan');" +
            "Insert INTO Countries(Name) VALUES('Spain');" +
            "Insert INTO Countries(Name) VALUES('Sri Lanka');" +
            "Insert INTO Countries(Name) VALUES('Sudan');" +
            "Insert INTO Countries(Name) VALUES('Suriname');" +
            "Insert INTO Countries(Name) VALUES('Swaziland');" +
            "Insert INTO Countries(Name) VALUES('Sweden');" +
            "Insert INTO Countries(Name) VALUES('Switzerland');" +
            "Insert INTO Countries(Name) VALUES('Syria');" +
            "Insert INTO Countries(Name) VALUES('Tajikistan');" +
            "Insert INTO Countries(Name) VALUES('Tanzania');" +
            "Insert INTO Countries(Name) VALUES('Thailand');" +
            "Insert INTO Countries(Name) VALUES('Timor Leste');" +
            "Insert INTO Countries(Name) VALUES('Togo');" +
            "Insert INTO Countries(Name) VALUES('Trinidad & Tobago');" +
            "Insert INTO Countries(Name) VALUES('Tunisia');" +
            "Insert INTO Countries(Name) VALUES('Turkey');" +
            "Insert INTO Countries(Name) VALUES('Turkmenistan');" +
            "Insert INTO Countries(Name) VALUES('Turks & Caicos Islands');" +
            "Insert INTO Countries(Name) VALUES('Uganda');" +
            "Insert INTO Countries(Name) VALUES('Ukraine');" +
            "Insert INTO Countries(Name) VALUES('United Arab Emirates');" +
            "Insert INTO Countries(Name) VALUES('United States of America (USA)');" +
            "Insert INTO Countries(Name) VALUES('Uruguay');" +
            "Insert INTO Countries(Name) VALUES('Uzbekistan');" +
            "Insert INTO Countries(Name) VALUES('Venezuela');" +
            "Insert INTO Countries(Name) VALUES('Vietnam');" +
            "Insert INTO Countries(Name) VALUES('Virgin Islands (UK)');" +
            "Insert INTO Countries(Name) VALUES('Virgin Islands (US)');" +
            "Insert INTO Countries(Name) VALUES('Yemen');" +
            "Insert INTO Countries(Name) VALUES('Zambia');" +
            "Insert INTO Countries(Name) VALUES('Zimbabwe');";
            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                return connection.Execute(sql);
            }
        }

    }
}
