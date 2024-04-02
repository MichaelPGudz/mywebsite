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
                    options.UseSqlServer(configuration.GetConnectionString("MainPageDatabase")));

        public static IServiceCollection AddServerServices(this IServiceCollection services) =>
            services.AddScoped<HomeService, ServerHomeService>();

        public static IServiceCollection AddClientServices(this IServiceCollection services) =>
            services.AddScoped<HomeService, ClientHomeService>();

        public static void RunMigrations(this IServiceProvider provider)
        {
            using (var scope = provider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                db.Database.Migrate();
            }
        }
    }
}
