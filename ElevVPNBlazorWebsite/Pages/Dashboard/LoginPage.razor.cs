using ElevVPNBlazorWebsite.Data.FormModels;
using System.Threading.Tasks;

namespace ElevVPNBlazorWebsite.Pages.Dashboard
{
    public partial class LoginPage
    {
        private LoginModel _loginModel = new();

        private Task OnValidSubmit_LoginAdmin()
        {
            _loginModel.IsProccessing = true;


            _loginModel.IsProccessing = false;
            return Task.CompletedTask;
        }
    }
}
