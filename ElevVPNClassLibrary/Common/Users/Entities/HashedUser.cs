namespace ElevVPNClassLibrary.Common.Users.Entities
{
    internal class HashedUser : IHashedUser
    {
        public int Id {get;set;}
        public string Password { get; set; }
        public string Salt { get; set; }

    }
}
