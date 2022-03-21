using ElevVPNClassLibrary.Core.Settings;
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

        public MySqlConnection CreateConnection()
        {
            var connStr = CreateConnectionString();
            var sqlConn = new MySqlConnection(connStr);
            return sqlConn;
        }

        private string CreateConnectionString()
        {
            var sb = new StringBuilder();
            sb.Append($"Server={_connectionSettings.ServerHost};");
            sb.Append($"Database={_connectionSettings.Database};");
            sb.Append($"User Id={_connectionSettings.Username};");
            sb.Append($"Password={_connectionSettings.Password};");

            return sb.ToString();
        }
    }
}
