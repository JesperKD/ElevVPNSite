using MySql.Data.MySqlClient;
using System;

namespace ElevVPNClassLibrary.Core.Database.Managers
{
    public interface ISqlDbManager
    {
        /// <summary>
        /// Get an <see cref="MySqlConnection"/>.
        /// </summary>
        /// <param name="connectionType">Defines the credentials used for the sql connection.</param>
        /// <returns>An initialized sql connection.</returns>
        /// <exception cref="ArgumentException">Is thrown whenever a credential type isn't supported.</exception>
        MySqlConnection GetSqlConnection();
    }
}
