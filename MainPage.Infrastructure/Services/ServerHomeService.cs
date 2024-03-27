using MainPage.Domain.Entities;
using MainPage.Domain.Services;
using MainPage.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace MainPage.Infrastructure.Services
{
    public sealed class ServerHomeService : HomeService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
        public ServerHomeService(IDbContextFactory<ApplicationDbContext> factory)
        {
            _dbContextFactory = factory;
        }

        public async Task<IEnumerable<Experience>> GetAllExpieriences()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {

            return await context.Experiences
                .Include(e => e.Description)
                .ToListAsync();
            }
        }    
        public async Task<IEnumerable<Skill>> GetAllSkills()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Skills.ToListAsync();
            }
        }
    }
}
