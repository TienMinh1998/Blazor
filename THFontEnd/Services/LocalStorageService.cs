using Microsoft.JSInterop;

namespace THFontEnd.Services
{
    public class LocalStorageService
    {
        private readonly IJSRuntime JS;

        public LocalStorageService(IJSRuntime jS)
        {
            JS = jS;
        }

        public async Task<int> GetUserId()
        {
            var result =  await JS.InvokeAsync<string>("localStorageHelper.getUserId");
            return int.Parse(result);
        }

    }
}
