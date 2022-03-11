using ElevVPNClassLibrary.Common.Users.Factories;
using ElevVPNClassLibrary.Common.Users.Repositories;
using ElevVpnTestLibrary.Setup;
using NUnit.Framework;

namespace ElevVpnTestLibrary
{
    public class RepositoryTests
    {
        private IUserRepository _userRepository;
        [SetUp]
        public void Setup()
        {
            var manager = SqlConfigurationSetup.SetupSqlDbManager();
            var factory = new UserEntityFactory();
            _userRepository = new UserRepository(manager, factory);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}