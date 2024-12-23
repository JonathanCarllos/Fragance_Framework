﻿using Fragance_Framework.Areas.Admin.Models;
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
        public DbSet<MakePerfPremium>? MakePerfPremium { get; set; }
        public DbSet<TopBeauty>? TopBeauty { get; set; }
        public DbSet<Premium>? Premium { get; set; }
        public DbSet<PremiumGel>? PremiumGel { get; set; }
        public DbSet<Rabisque>? Rabisque { get; set; }
        public DbSet<RabisqueNovo>? RabisqueNovos { get; set; }
        public DbSet<Alcool>? Alcool { get; set; }
        public DbSet<SosUnhas> SosUnhas { get; set; }
    }
}

