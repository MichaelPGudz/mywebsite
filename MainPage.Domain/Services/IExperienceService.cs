using MainPage.Domain.Entities;

namespace MainPage.Domain.Services
{
    public interface IExperienceService
    {
        Task<IEnumerable<Experience>> GetAllExpieriences();
    }
}
