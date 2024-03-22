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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experience>().Property(e => e.JobTitle).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Experience>().Property(e => e.CompanyName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Experience>().Property(e => e.Location).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Experience>().Property(e => e.IsRemote).IsRequired();
            modelBuilder.Entity<Experience>().Property(e => e.StartDate).IsRequired().HasColumnType("date");
            modelBuilder.Entity<Experience>().Property(e => e.EndDate).HasColumnType("date");

            modelBuilder.Entity<WorkDetail>().Property(e => e.DescriptionElement).IsRequired();

            modelBuilder.Entity<Skill>().Property(e => e.Name).IsRequired().HasMaxLength(50);
        }
    }
}
