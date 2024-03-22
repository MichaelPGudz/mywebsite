using MainPage.Domain.Entities;
using System.Net.Http.Json;

namespace MainPage.Infrastructure.Repositories
{
    public class ClientExperienceService
    {
        private readonly HttpClient _httpClient;

        public ClientExperienceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Experience>> GetAllExperienceAsync()
        {
            var result = await _httpClient.GetAsync("api/Experience");
            return await result.Content.ReadFromJsonAsync<List<Experience>>() ?? new List<Experience>();
        }
    }
}
