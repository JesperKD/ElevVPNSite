namespace ElevVPNClassLibrary.Common.User.Entities
{
    public class Admin : IUser
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
