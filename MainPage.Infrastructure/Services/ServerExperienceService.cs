using MainPage.Domain.Entities;
using MainPage.Domain.Services;
using MainPage.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace MainPage.Infrastructure.Services
{
    public sealed class ServerExperienceService : IExperienceService
    {
        private readonly ApplicationDbContext _context;
        public ServerExperienceService(IDbContextFactory<ApplicationDbContext> factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task<IEnumerable<Experience>> GetAllExpieriences()
        {
            return await _context.Experiences.ToListAsync();
        }
    }
}
