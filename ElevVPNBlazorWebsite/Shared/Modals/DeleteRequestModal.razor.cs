using ElevVPNBlazorWebsite.Data.Providers;
using ElevVPNClassLibrary.Common.Users.Entities;
using ElevVPNClassLibrary.Common.Users.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace ElevVPNBlazorWebsite.Shared.Modals
{
    public partial class DeleteRequestModal : ComponentBase
    {
        [Parameter] public int Id { get; set; }
        [Inject] protected IRefreshProvider RefreshProvider { get; set; }
        [Inject] protected IJSRuntime JSRuntime { get; set; }
        [Inject] protected IUserService UserService { get; set; }

        private string _errorMessage = "";
        private bool _isProcessing = false;

        private async Task OnClick_RemoveUserAsync(int id)
        {
            try
            {
                _isProcessing = true;

                User user = new()
                {
                    Id = id
                };

                var result = await UserService.RemoveAsync(user);

                if (!result)
                {
                    _errorMessage = "Kunne ikke fjerne brugeren, den er muligvis allerede slettet.";

                    return;
                }

                RefreshProvider.CallRefreshRequest();
                await JSRuntime.InvokeVoidAsync("toggleModalVisibility", "ModalRemoveVacantJob");
            }
            catch (Exception ex)
            {
                _errorMessage = "Kunne ikke fjerne brugeren grundet ukendt fejl.";
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _isProcessing = false;
            }
        }

        private void CancelRequest()
        {
            RefreshProvider.CallRefreshRequest();
        }
    }
}
