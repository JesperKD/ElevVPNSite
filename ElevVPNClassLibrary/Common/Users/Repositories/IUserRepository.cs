using ElevVPNClassLibrary.Common.Users.Entities;
using ElevVPNClassLibrary.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevVPNClassLibrary.Common.Users.Repositories
{
    public interface IUserRepository : IRepository<IUser, int>
    {
        
    }
}
