using MainPage.Domain.Entities;
using MainPage.Domain.Services;
using System.Net.Http.Json;

namespace MainPage.Infrastructure.Services
{
    public class ClientHomeService : HomeService
    {
        private readonly HttpClient _httpClient;

        public ClientHomeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Experience>> GetAllExpieriences() =>
            await _httpClient.GetFromJsonAsync<IEnumerable<Experience>>("api/home/experiences") ?? new List<Experience>();  
        public async Task<IEnumerable<Skill>> GetAllSkills() =>
            await _httpClient.GetFromJsonAsync<IEnumerable<Skill>>("api/home/skills") ?? new List<Skill>();
    }
}
