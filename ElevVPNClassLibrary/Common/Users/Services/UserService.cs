using ElevVPNClassLibrary.Common.Users.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevVPNClassLibrary.Common.Users.Services
{
    public class UserService : IUserService
    {
        public Task<bool> AuthenticateUserLoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckUserExistsAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IUser> CreateAsync(IUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<IUser> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSaltByEmailAddressAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IUser> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IUser>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IUser> GrantAreaToUserAsync(IUser user, int areaId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(IUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<IUser> RevokeAreaFromUserAsync(IUser user, int areaId)
        {
            throw new NotImplementedException();
        }

        public Task<IUser> UpdateAsync(IUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserPasswordAsync(IUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateUserAccessTokenAsync(string accessToken)
        {
            throw new NotImplementedException();
        }
    }
}
