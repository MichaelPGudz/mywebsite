using MainPage.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MainPage.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
