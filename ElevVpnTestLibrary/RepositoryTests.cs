using ElevVPNClassLibrary.Common.Users.Entities;
using ElevVPNClassLibrary.Common.Users.Factories;
using ElevVPNClassLibrary.Common.Users.Repositories;
using ElevVpnTestLibrary.Setup;
using NUnit.Framework;
using System.Threading.Tasks;

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
        [Order(0)]
        public async Task GetAllAsync_HasData_IfCollectionIsNotNull()
        {
            // Arrange
            IUser firstUser;

            // Act
            var users = await _userRepository.GetAllSystemLogsAsync();
            firstUser = users[0];

            // Assert
            Assert.IsNotNull(users);
            Assert.IsNotEmpty(users);
            Assert.IsNotNull(firstUser);
            Assert.AreNotEqual(0, firstUser.Id);
            Assert.IsNotNull(firstUser.Email);
            Assert.IsNotEmpty(firstUser.Email);
        }
    }
}