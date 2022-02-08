using Microsoft.AspNetCore.Components;

namespace ElevVPNBlazorWebsite.Shared.Components.Redirects
{
    public class HomePageRedirect : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            NavigationManager.NavigateTo("", true);
        }
    }
}
