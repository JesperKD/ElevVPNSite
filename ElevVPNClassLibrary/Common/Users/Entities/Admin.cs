namespace ElevVPNClassLibrary.Common.Users.Entities
{
    public class Admin : IUser, IAuthUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string AccessToken { get; set; }
    }
}
