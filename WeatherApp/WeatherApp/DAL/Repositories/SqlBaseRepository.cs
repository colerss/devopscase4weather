using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Dapper;
using Microsoft.Data.Sqlite;

namespace WeatherApp.DAL.Repositories
{
    class SqlBaseRepository
    {
        public SqlBaseRepository()
        {

        }

        public static SqliteConnection DbConnectionFactory()
        {
            return new SqliteConnection(@"DataSource=WeatherAppDB.sqlite");
        }
        protected static bool DatabaseExists()
        {
            return File.Exists(@"WeatherAppDB.sqlite");
        }
        protected static void CreateDatabase()
        {
            using (var connection = DbConnectionFactory())
            {
                connection.Open();
                connection.Execute(
                    @"CREATE TABLE Countries
                    (
                    Id                                  INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name                              VARCHAR(50) UNIQUE
                    )");
            }
        }

    }
}
