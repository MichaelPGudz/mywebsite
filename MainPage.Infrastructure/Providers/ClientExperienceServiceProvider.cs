using MainPage.Application.Providers;
using MainPage.Domain.Entities;
using MainPage.Infrastructure.Repositories;

namespace MainPage.Infrastructure.Providers
{
    public class ClientExperienceServiceProvider : IExperienceProvider
    {
        private readonly ClientExperienceService _service;

        public ClientExperienceServiceProvider(ClientExperienceService service)
        {
            _service = service;
        }
        public async Task<IEnumerable<Experience>> FetchAsync()
        {
            return await _service.GetAllExperienceAsync();
        }
    }
}
