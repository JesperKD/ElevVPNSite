using System;
using System.Threading.Tasks;

namespace ElevVPNBlazorWebsite.Data.Providers
{
    public class RefreshProvider : IRefreshProvider
    {
        public event Func<Task> RefreshRequest;

        public void CallRefreshRequest()
        {
            RefreshRequest?.Invoke();
        }
    }
}
