using ElevVPNClassLibrary.Common.Users.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevVPNClassLibrary.Common.Users.Repositories
{
    internal class UserRepository : IUserRepository
    {
        public Task<IUser> CreateAsync(IUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<IUser>> GetAllSystemLogsAsync()
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
