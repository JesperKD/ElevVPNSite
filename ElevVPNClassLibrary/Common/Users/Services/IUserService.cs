using ElevVPNClassLibrary.Common.Users.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevVPNClassLibrary.Common.Users.Services
{
    public interface IUserService
    {
        Task<bool> AuthenticateUserLoginAsync(string email, string password);

        Task<List<IUser>> GetUsersAsync();

        Task<IUser> CreateAsync(IUser entity);

        Task<IUser> GetUserByIdAsync(int id);

        Task<IUser> UpdateAsync(IUser entity);

        Task<IUser> GetByEmailAsync(string email);

        Task<IUser> GrantAreaToUserAsync(IUser user, int areaId);

        Task<IUser> RevokeAreaFromUserAsync(IUser user, int areaId);

        Task<bool> RemoveAsync(IUser entity);

        Task<bool> CheckUserExistsAsync(string email);
    }
}
