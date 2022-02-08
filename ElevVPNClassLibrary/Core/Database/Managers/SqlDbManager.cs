using ElevVPNClassLibrary.Core.Database.Factories;
using System.Data.SqlClient;

namespace ElevVPNClassLibrary.Core.Database.Managers
{
    public class SqlDbManager : ISqlDbManager
    {
        private readonly ISqlDbFactory _factory;

        public SqlDbManager(ISqlDbFactory factory)
        {
            _factory = factory;
        }

        public SqlConnection GetSqlConnection()
        {
            return _factory.CreateConnection("username", "Pa$$w0rd");
        }
    }
}
