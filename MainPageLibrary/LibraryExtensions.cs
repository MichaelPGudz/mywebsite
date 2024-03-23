using Microsoft.Extensions.DependencyInjection;

namespace MainPageLibrary
{
    public static class LibraryExtensions
    {
        public static IServiceCollection AddLibraryExtensions(this IServiceCollection services) 
            => services.AddScoped<BaseJsInterop>();
    }
}
