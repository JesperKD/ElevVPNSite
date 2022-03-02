using System;
using System.Threading.Tasks;

namespace ElevVPNBlazorWebsite.Data.Providers
{
    public interface IRefreshProvider
    {
        event Func<Task> RefreshRequest;

        void CallRefreshRequest();
    }
}
