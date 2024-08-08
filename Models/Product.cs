using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kasir.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Price).HasColumnType("int").IsRequired();
                entity.Property(e => e.Stock).HasColumnType("int").IsRequired();
            });
        }
    }
}
