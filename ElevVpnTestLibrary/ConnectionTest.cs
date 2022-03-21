using ElevVPNClassLibrary.Core.Database.Managers;
using ElevVpnTestLibrary.Setup;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace ElevVpnTestLibrary
{
    internal class ConnectionTest
    {
        ISqlDbManager _sqlDbManager = null;

        [SetUp]
        public void Setup()
        {
            _sqlDbManager = SqlConfigurationSetup.SetupSqlDbManager();
        }

        [Test]
        public async Task TestConnection()
        {
            bool couldConnect = false;

            using (var mysqlconnection = _sqlDbManager.GetSqlConnection()) 
            {
                try
                {
                    await mysqlconnection.OpenAsync();
                    couldConnect = true;
                }
                catch (Exception)
                {
                    couldConnect = false;
                }
            }

            Assert.IsTrue(couldConnect);
        }

    }
}
