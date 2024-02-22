using MainPageLibrary;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace MainPage.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped<BaseJsInterop>();

            await builder.Build().RunAsync();
        }
    }
}
