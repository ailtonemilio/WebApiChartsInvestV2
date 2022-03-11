using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApiChartsInvestV2.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApiChartsInvestV2.Data.Config
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options)
            : base(options)
        { }

        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<QuestradeToken> QuestradeToken { get; set; }
        public DbSet<Stock> Stock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Portfolio>().ToTable("Portfolio").HasKey(t => t.PortfolioId);

        //    base.OnModelCreating(builder);
        //}
        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=localhost;Initial Catalog=ChartsInvest;Integrated Security=False;User ID=sa;Password=Ae190273;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            // string strCon = "Server=tcp:canaldevcore.database.windows.net,1433;Initial Catalog=dev;Persist Security Info=False;User ID=valdir;Password=@Beatriz222;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return strCon;
        }
    }
}
