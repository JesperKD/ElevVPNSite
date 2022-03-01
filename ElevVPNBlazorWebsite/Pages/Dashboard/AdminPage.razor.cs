using System.Threading.Tasks;

namespace ElevVPNBlazorWebsite.Pages.Dashboard
{
    public partial class AdminPage
    {


        private string _errorMessage = string.Empty;
        private string _successMessage = string.Empty;
        private bool _isLoadingData = false;


        private async Task OnDelete_DeletePersonData()
        {
            await Task.CompletedTask;
        }


    }
}
