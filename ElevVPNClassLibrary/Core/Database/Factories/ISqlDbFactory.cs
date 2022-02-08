using System.Data.SqlClient;

namespace ElevVPNClassLibrary.Core.Database.Factories
{
    public interface ISqlDbFactory
    {
        SqlConnection CreateConnection(string username, string password);
    }
}
