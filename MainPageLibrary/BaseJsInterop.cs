using Microsoft.JSInterop;

namespace MainPageLibrary
{
    public class BaseJsInterop : IAsyncDisposable
    {
        protected readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public BaseJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/MainPageLibrary/baseJsInterop.js").AsTask());
                
            
            //"./Components/Layout/NavMenu.razor.js")
                
            //"import", "./_content/MainPageLibrary/baseJsInterop.js"
        }

        public async ValueTask<string> ScrollToSection(string sectionId)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("scrollToSection", sectionId);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
