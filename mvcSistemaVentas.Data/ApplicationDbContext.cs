using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvcSistemaVentas.Models;

namespace mvcSistemaVentas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Slider> Slider{ get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
