
using InfluPro.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InfluPro.BLL.Data
{
    public class AppDbContext : IdentityDbContext <ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure your entities here
            // Example: modelBuilder.Entity<Profile>().ToTable("Profiles");
        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfileTypes> ProfileTypes { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        
        // DbSet properties for your entities
        // public DbSet<Profile> Profiles { get; set; }
        // public DbSet<ProfileTypes> ProfileTypes { get; set; }
        // public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}
