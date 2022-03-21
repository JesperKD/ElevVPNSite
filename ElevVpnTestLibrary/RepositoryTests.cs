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

        [Test]
        [Order(2)]
        public async Task GetByIdAsync_ReturnsAValidObject_IfArgumentIsValid()
        {
            //Arrange
            IUser testArea;
            IUser requestedArea;

            testArea = await _userRepository.CreateAsync(CreateTestAreaObject());

            //Act
            requestedArea = await _userRepository.GetByIdAsync(testArea.Id);

            //cleanup
            bool cleanUpAreaTest = await _userRepository.RemoveAsync(requestedArea);

            //Assert
            Assert.IsNotNull(requestedArea);
            Assert.IsNotNull(requestedArea.Id);
            Assert.AreNotEqual(0, requestedArea.Id);
            Assert.AreEqual(testArea.Email, requestedArea.Email);
            Assert.IsTrue(cleanUpAreaTest);
        }


        [Test]
        [Order(3)]
        public async Task UpdateAsync_UpdatesExistingObject_IfArgumentsIsValid()
        {
            //Arrange
            IUser testArea;
            IUser newArea;
            IUser updatedArea;

            testArea = await _userRepository.CreateAsync(CreateTestAreaObject());

            //Act
            newArea = new User
            {
                Id = testArea.Id,
                Email = CreateTestAreaObject().Email
            };

            updatedArea = await _userRepository.UpdateAsync(newArea);

            //Cleanup
            bool cleanUpAreaTest = await _userRepository.RemoveAsync(updatedArea);

            //Assert
            Assert.IsNotNull(updatedArea);
            Assert.IsNotNull(updatedArea.Email);
            Assert.AreEqual(newArea.Email, updatedArea.Email);
            Assert.IsTrue(cleanUpAreaTest);
        }


        [Test]
        [Order(4)]
        public async Task RemoveArea_ShouldRemoveArea()
        {
            //Arrange
            IUser testArea;
            testArea = await _userRepository.CreateAsync(CreateTestAreaObject());

            //Act
            bool cleanupSuccess = await _userRepository.RemoveAsync(testArea);

            //Assert
            Assert.IsTrue(cleanupSuccess);
        }


    }
}