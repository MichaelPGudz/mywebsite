using MainPage.Infrastructure;
using MainPageLibrary;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace MainPage.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddLibraryExtensions();
            builder.Services.AddScoped(http => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
            });
            builder.Services.AddClientServices();


            await builder.Build().RunAsync();
        }
    }
}
