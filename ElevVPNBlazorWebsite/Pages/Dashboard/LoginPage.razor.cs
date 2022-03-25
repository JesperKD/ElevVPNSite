using ElevVPNBlazorWebsite.Data.FormModels;
using ElevVPNClassLibrary.Common.Users.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace ElevVPNBlazorWebsite.Pages.Dashboard
{
    public partial class LoginPage
    {
        [Inject] protected IUserService UserService { get; set; }
        private readonly LoginModel _loginModel = new();

        private string _errorMessage = string.Empty;
        private string _successMessage = string.Empty;

        private async Task OnValidSubmit_LoginAdmin()
        {
            _loginModel.IsProcessing = true;

            try
            {
                await UserService.AuthenticateUserLoginAsync(_loginModel.Email, _loginModel.Password);
            }
            catch (Exception ex)
            {
                _errorMessage = "Kunne ikke logge ind, prøv igen.";
                Console.WriteLine("Login error: " + ex.Message);
            }
            _loginModel.IsProcessing = false;
        }
    }
}
