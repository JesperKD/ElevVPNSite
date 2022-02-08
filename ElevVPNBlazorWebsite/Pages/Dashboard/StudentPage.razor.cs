using ElevVPNBlazorWebsite.Data.FormModels;
using System.Threading.Tasks;

namespace ElevVPNBlazorWebsite.Pages.Dashboard
{
    public partial class StudentPage
    {

        private RequestModel _requestModel = new();


        private Task OnValidSubmit_AddRequestEmail()
        {
            _requestModel.IsProccessing = true;




            _requestModel.IsProccessing = false;
            return Task.CompletedTask;
        }

    }
}
