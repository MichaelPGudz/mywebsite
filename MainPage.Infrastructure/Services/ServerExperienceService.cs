using MainPage.Domain.Entities;
using MainPage.Domain.Services;
using MainPage.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace MainPage.Infrastructure.Services
{
    public sealed class ServerExperienceService : IExperienceService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _context;
        public ServerExperienceService(IDbContextFactory<ApplicationDbContext> factory)
        {
            _context = factory;
        }

        public async Task<IEnumerable<Experience>> GetAllExpieriences()
        {
            using (var context = _context.CreateDbContext())
            {

            return await context.Experiences
                .Include(e => e.Description)
                .ToListAsync();
            }
        }    
        public async Task<IEnumerable<Skill>> GetAllSkills()
        {
            using (var context = _context.CreateDbContext())
            {
                return await context.Skills.ToListAsync();
            }
        }
    }
}
