using MainPage.Domain.Services;
using MainPage.Infrastructure.Database;
using MainPage.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MainPage.Infrastructure
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContextFactory<ApplicationDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("MainPageConnetion")));

        public static IServiceCollection AddServerServices(this IServiceCollection services) =>
            services.AddScoped<IExperienceService, ServerExperienceService>();

        public static IServiceCollection AddClientServices(this IServiceCollection services) =>
            services.AddScoped<IExperienceService, ClientExperienceService>();

    }
}
