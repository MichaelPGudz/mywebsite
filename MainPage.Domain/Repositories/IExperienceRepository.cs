using MainPage.Domain.Entities;

namespace MainPage.Domain.Repositories
{
    public interface IExperienceRepository
    {
        Task<IEnumerable<Experience>> GetAllAsync();
        Task<Experience> GetById(int id);
        Task Add(Experience experience);
    }
}
