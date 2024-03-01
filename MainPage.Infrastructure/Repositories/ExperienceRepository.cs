using MainPage.Domain.Entities;
using MainPage.Domain.Repositories;
using MainPage.Infrastructure.Database;

namespace MainPage.Infrastructure.Repositories
{
    public sealed class ExperienceRepository : IExperienceRepository
    {
        private readonly ApplicationDbContext _context;
        public ExperienceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Add(Experience experience)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Experience>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Experience> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
