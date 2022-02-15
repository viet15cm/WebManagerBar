using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebManager.Models;
using WebManager.Models.Identity;

namespace WebManager.DbContextlayer
{
    public class UserContext : IdentityDbContext<AppUser>
    {
        public IConfiguration Configuration { get; }

        public UserContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("ContextConnection"));

        }

        public DbSet<Food> foods { get; set; }
        public DbSet<Invoice> invoices { get; set; }

        public DbSet<InvoiceDetail> invoiceDetails { get; set; }

        public DbSet<Warehouse> warehouses { get; set; }
        public DbSet<Eating> eatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var item in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = item.GetTableName();

                if (tableName.StartsWith("AspNet"))
                {
                    item.SetTableName(tableName.Substring(6));
                }

            }
            
            modelBuilder.Entity<Food>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Invoice>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Warehouse>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Eating>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Eating>()
            .HasOne(s => s.Food)
            .WithMany(g => g.Eatings)
            .HasForeignKey(s => s.FoodId);

            modelBuilder.Entity<Warehouse>()
            .HasOne(s => s.Food)
            .WithMany(g => g.Warehouses)
            .HasForeignKey(s => s.FoodId);

            modelBuilder.Entity<InvoiceDetail>()
               .HasKey(bc => new { bc.EatingId, bc.InvoiceId });

            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(bc => bc.Eating)
                .WithMany(b => b.InvoiceDetails)
                .HasForeignKey(bc => bc.EatingId);

            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(bc => bc.Invoice)
                .WithMany(c => c.InvoiceDetails)
                .HasForeignKey(bc => bc.InvoiceId);

        }
    }
}
