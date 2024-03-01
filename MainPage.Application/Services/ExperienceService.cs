using MainPage.Domain.Entities;
using MainPage.Domain.Repositories;

namespace MainPage.Application.Interfaces
{
    public sealed class ExperienceService
    {
        private readonly IExperienceRepository _experienceRepository;

        public ExperienceService(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        public async Task<IEnumerable<Experience>> GetAllExperiences()
            => await _experienceRepository.GetAllAsync();    
        
        public async Task<Experience> GetExperienceById(int id)
            => await _experienceRepository.GetById(id);    
        
        public async Task AddExperience(Experience experience)
            => await _experienceRepository.Add(experience);
    }
}
