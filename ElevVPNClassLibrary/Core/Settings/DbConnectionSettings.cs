namespace ElevVPNClassLibrary.Core.Settings
{
    public class DbConnectionSettings : IConnectionSettings
    {
        public string ConnectionString { get; set; }

        public string ServerHost { get; set; }

        public string Database { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
