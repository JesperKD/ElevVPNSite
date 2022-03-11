using ElevVPNClassLibrary.Core.Database.Factories;
using ElevVPNClassLibrary.Core.Database.Managers;
using ElevVPNClassLibrary.Core.Settings;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ElevVpnTestLibrary.Setup
{
    public static class SqlConfigurationSetup
    {
        public static ISqlDbManager SetupSqlDbManager()
        {
            var inMemorySettings = new Dictionary<string, string>
            {
                {"ServerHost", "172.18.5.23" },
                {"Database", "EmailDB" }
            };

            IConfiguration config = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();

            IConnectionSettings settings = config.Get<DbConnectionSettings>();

            ISqlDbFactory factory = new SqlDbFactory(settings);
            return new SqlDbManager(factory);
        }
    }
}
