using ElevVPNClassLibrary.Common.Users.Entities;

namespace ElevVPNClassLibrary.Security.Cryptography
{
    public interface ICryptographyService
    {
        IHashedUser CreateHashedUser(string password);

        string HashUserPasswordWithSalt(string password, string salt);
    }
}
