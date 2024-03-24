using MainPage.Domain.Entities;

namespace MainPage.Domain.Services
{
    public interface HomeService
    {
        Task<IEnumerable<Experience>> GetAllExpieriences();
        Task<IEnumerable<Skill>> GetAllSkills();
    }
}
