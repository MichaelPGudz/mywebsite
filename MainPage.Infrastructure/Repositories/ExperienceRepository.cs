using MainPage.Domain.Entities;
using MainPage.Domain.Repositories;
using MainPage.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace MainPage.Infrastructure.Repositories
{
    public sealed class ExperienceRepository : IExperienceRepository
    {
        private readonly ApplicationDbContext _context;
        public ExperienceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Experience>> GetAllAsync()
        {
            return await _context.Experiences.ToListAsync() ;
        }
    }
}
