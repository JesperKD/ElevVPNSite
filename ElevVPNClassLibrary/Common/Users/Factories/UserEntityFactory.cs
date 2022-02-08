using ElevVPNClassLibrary.Common.Users.Entities;
using ElevVPNClassLibrary.Core.Factories;
using ElevVPNClassLibrary.Core.Repositories;
using System;

namespace ElevVPNClassLibrary.Common.Users.Factories
{
    public class UserEntityFactory : FactoryParser
    {
        public IAggregateRoot CreateEntity(string paramName, params object[] entityValues) => paramName switch
        {
            nameof(User) => new User
            {
                Id = ParseValue<int>(entityValues[0]),
                Email = ParseValue<string>(entityValues[1])
            },
            nameof(Admin) => new Admin
            {
                Id = ParseValue<int>(entityValues[0]),
                Email = ParseValue<string>(entityValues[1]),
                Password = ParseValue<string>(entityValues[2])
            },
            nameof(HashedUser) => new Admin
            {
                Id = ParseValue<int>(entityValues[0]),
                Password = ParseValue<string>(entityValues[1]),
                Salt = ParseValue<string>(entityValues[2])
            },
            _ => throw new ArgumentOutOfRangeException(nameof(paramName), paramName, "Coudln't create type. Out of range.")
        };
    }
}
