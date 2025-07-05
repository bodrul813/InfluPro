
using InfluPro.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InfluPro.BLL.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<ProfileTypes> ProfilesTypes { get; set; }
    }
}
