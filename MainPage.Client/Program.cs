using MainPage.Application.Providers;
using MainPage.Infrastructure.Providers;
using MainPage.Infrastructure.Repositories;
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
            builder.Services.AddScoped(http => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
            });
            builder.Services.AddScoped<ClientExperienceService>();
            builder.Services.AddScoped<IExperienceProvider, ClientExperienceServiceProvider>();

            await builder.Build().RunAsync();
        }
    }
}
