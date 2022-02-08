using ElevVPNClassLibrary.Core.Entities;
using ElevVPNClassLibrary.Core.Repositories;

namespace ElevVPNClassLibrary.Common.Users.Entities
{
    public interface IUser : IAggregateRoot, IEntity<int>
    {
        public string Email { get; }
    }
}
