using MainPage.Domain.Entities;

namespace MainPage.Application.Providers
{
    public interface IExperienceProvider
    {
        public Task<IEnumerable<Experience>> FetchAsync();
    }
}
