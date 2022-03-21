using ElevVPNClassLibrary.Common.Users.Entities;
using ElevVPNClassLibrary.Common.Users.Factories;
using ElevVPNClassLibrary.Common.Users.Repositories;
using ElevVpnTestLibrary.Setup;
using NUnit.Framework;
using System;
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
            var users = await _userRepository.GetAllAsync();
            firstUser = users[0];

            // Assert
            Assert.IsNotNull(users);
            Assert.IsNotEmpty(users);
            Assert.IsNotNull(firstUser);
            Assert.AreNotEqual(0, firstUser.Id);
            Assert.IsNotNull(firstUser.Email);
            Assert.IsNotEmpty(firstUser.Email);
        }

        [Test]
        [Order(1)]
        public async Task CreateAsync_CreatesAnArea_IfArgumentsAreValid()
        {
            //Arrange
            IUser expected;
            IUser actual;

            expected = CreateTestAreaObject();

            //Act
            actual = await _userRepository.CreateAsync(expected);
            bool cleanUpAreaTest = await _userRepository.RemoveAsync(actual);

            //Assert
            Assert.IsNotNull(actual);
            Assert.IsNotEmpty(actual.Email);
            Assert.AreNotEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.IsTrue(cleanUpAreaTest);
        }

        private static IUser CreateTestAreaObject()
        {
            IUser expected;
            var rnd = new Random(DateTime.Now.GetHashCode());
            string testUserMail = $"UnitTest{rnd.Next(3424, 458729)}";
            expected = new User
            {
                Id = 0,
                Email = testUserMail
            };
            return expected;
        }
    }
}