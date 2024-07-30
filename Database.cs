using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kasir.Models;
using Microsoft.EntityFrameworkCore;

namespace Kasir
{
    internal class Database : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Database=Kasir;Username=postgres;Password=123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Costumer.CreateModel(modelBuilder);
            Product.CreateModel(modelBuilder);
            Sale.CreateModel(modelBuilder);
            SaleDetail.CreateModel(modelBuilder);
            User.CreateModel(modelBuilder);
        }
    }
}
