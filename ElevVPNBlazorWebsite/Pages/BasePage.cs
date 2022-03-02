using ElevVPNBlazorWebsite.Data.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace ElevVPNBlazorWebsite.Pages
{
    /// <summary>
    /// Implements base events for pages
    /// </summary>
    public abstract class BasePage : ComponentBase
    {
        [Inject] public NavigationManager NavigationManager { get; set; }
        [Inject] public PaginationService PaginationService { get; set; }

        public string Message { get; set; }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                PaginationService.OnPageChange += OnPageChange_RenderPageAsync;
                PaginationService.OnPageSizeChange += OnPageSizeChange_RenderPageAsync;
            }
        }

        protected override void OnParametersSet()
        {
            PaginationService.CurrentPage = 1;
        }

        public async Task OnPageChange_RenderPageAsync()
        {
            await InvokeAsync(StateHasChanged);
        }

        public async Task OnPageSizeChange_RenderPageAsync()
        {
            await InvokeAsync(StateHasChanged);
        }

        public void OnMessageCleared_ClearMessage(object sender, bool isCleared)
        {
            if (isCleared)
            {
                Message = string.Empty;
            }
        }
    }
}
