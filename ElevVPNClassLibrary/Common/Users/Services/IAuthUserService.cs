using ElevVPNClassLibrary.Common.Users.Entities;
using System.Threading.Tasks;

namespace ElevVPNClassLibrary.Common.Users.Services
{
    public interface IAuthUserService
    {
        Task<IAuthUser> AuthenticateUserLoginAsync(string email, string password);

        Task<IAuthUser> GetUserByAccessTokenAsync(string accessToken);

        Task<string> GetSaltByEmailAddressAsync(string email);

        Task<bool> UpdateUserPasswordAsync(IAuthUser user);

        Task<bool> ValidateUserAccessTokenAsync(string accessToken);
    }
}
