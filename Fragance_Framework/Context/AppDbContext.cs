using Fragance_Framework.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fragance_Framework.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Envase>? EnvasesSetup { get; set; } 
        public DbSet<Maquiagens>? Maquiagens { get; set; }
    }
}

