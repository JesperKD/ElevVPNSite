using ElevVPNBlazorWebsite.Data.FormModels;
using System.Threading.Tasks;

namespace ElevVPNBlazorWebsite.Pages.Dashboard
{
    public partial class StudentPage
    {

        private readonly RequestModel _requestModel = new();


        private Task OnValidSubmit_AddRequestEmail()
        {
            _requestModel.IsProcessing = true;




            _requestModel.IsProcessing = false;
            return Task.CompletedTask;
        }

    }
}
