using MainPage.Application.Providers;
using MainPage.Domain.Entities;
using MainPage.Domain.Repositories;

namespace MainPage.Infrastructure.Providers
{
    public sealed class ExperienceProvider : IExperienceProvider
    {
        private readonly IExperienceRepository _experienceRepository;

        public ExperienceProvider(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        public async Task<IEnumerable<Experience>> FetchAsync()
        {
            return await _experienceRepository.GetAllAsync();
        }
    }
}
