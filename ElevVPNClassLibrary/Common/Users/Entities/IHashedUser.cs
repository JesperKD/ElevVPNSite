using ElevVPNClassLibrary.Core.Entities;
using ElevVPNClassLibrary.Core.Repositories;

namespace ElevVPNClassLibrary.Common.Users.Entities
{
    public interface IHashedUser : IAggregateRoot, IEntity<int>
    {
        public string Password { get; }
        public string Salt { get; }
    }
}
