using MainPage.Domain.Entities;
using MainPage.Domain.Services;
using System.Net.Http.Json;

namespace MainPage.Infrastructure.Services
{
    public class ClientExperienceService : IExperienceService
    {
        private readonly HttpClient _httpClient;

        public ClientExperienceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Experience>> GetAllExpieriences() =>
            await _httpClient.GetFromJsonAsync<IEnumerable<Experience>>("api/Experience") ?? new List<Experience>();
    }
}
