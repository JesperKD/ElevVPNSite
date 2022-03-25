using ElevVPNClassLibrary.Common.Users.Entities;
using ElevVPNClassLibrary.Common.Users.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevVPNBlazorWebsite.Pages.Dashboard
{
    public partial class AdminPage
    {
        [Inject] protected IUserService UserService { get; set; }

        private IEnumerable<IUser> _users = new List<User>();

        private int _requestId;
        private bool _isLoadingData = false;
        private readonly string _errorMessage = string.Empty;
        private readonly string _successMessage = string.Empty;


        protected override async Task OnInitializedAsync()
        {
            //await LoadDataAsync();
            await Task.CompletedTask;
        }

        private async Task LoadDataAsync()
        {
            _isLoadingData = true;
            try
            {
                var userTask = UserService.GetUsersAsync();

                await Task.WhenAll(userTask);

                _users = userTask.Result;
            }
            finally
            {
                _isLoadingData = false;
                StateHasChanged();
            }
        }

        private void OnDeleteClick_DeleteUserData(int id)
        {
            _requestId = id;
        }
    }
}
