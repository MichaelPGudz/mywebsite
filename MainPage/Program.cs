using MainPage.Application.Providers;
using MainPage.Components;
using MainPage.Domain.Repositories;
using MainPage.Infrastructure.Database;
using MainPage.Infrastructure.Providers;
using MainPage.Infrastructure.Repositories;
using MainPageLibrary;
using Microsoft.EntityFrameworkCore;

namespace MainPage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            builder.Services.AddControllers();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("MainPageConnetion")));
            
            builder.Services.AddScoped<BaseJsInterop>();
            builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
            builder.Services.AddScoped<IExperienceProvider, ExperienceProvider>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.MapControllers();
            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}
