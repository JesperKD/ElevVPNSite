﻿using ElevVPNClassLibrary.Core.Settings;
using MySql.Data.MySqlClient;
using System.Text;

namespace ElevVPNClassLibrary.Core.Database.Factories
{
    public class SqlDbFactory : ISqlDbFactory
    {
        private readonly IConnectionSettings _connectionSettings;

        public SqlDbFactory(IConnectionSettings connectionSettings)
        {
            _connectionSettings = connectionSettings;
        }

        public MySqlConnection CreateConnection(string username, string password)
        {
            var connStr = CreateConnectionString(username, password);
            var sqlConn = new MySqlConnection(connStr);
            return sqlConn;
        }

        private string CreateConnectionString(string username, string password)
        {
            var sb = new StringBuilder();
            sb.Append($"Server={_connectionSettings.ServerHost};");
            sb.Append($"Database={_connectionSettings.Database};");
            sb.Append($"User Id={username};");
            sb.Append($"Password={password};");

            return sb.ToString();
        }
    }
}
