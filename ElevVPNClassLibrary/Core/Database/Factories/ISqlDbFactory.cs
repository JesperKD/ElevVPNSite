using MySql.Data.MySqlClient;

namespace ElevVPNClassLibrary.Core.Database.Factories
{
    public interface ISqlDbFactory
    {
        MySqlConnection CreateConnection();
    }
}
