using ElevVPNClassLibrary.Common.Users.Entities;
using ElevVPNClassLibrary.Common.Users.Factories;
using ElevVPNClassLibrary.Core.Database.Managers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevVPNClassLibrary.Common.Users.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ISqlDbManager _sqlDbManager;
        private readonly UserEntityFactory _factory;

        public UserRepository(ISqlDbManager sqlDbManager, UserEntityFactory factory)
        {
            _sqlDbManager = sqlDbManager;
            _factory = factory;
        }


        public Task<IUser> CreateAsync(IUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<IUser>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IUser> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(IUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<IUser> UpdateAsync(IUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
