using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kasir.Models
{
    internal class SaleDetail
    {
        public int Id { get; set; }
        public Product Productid { get; set; }
        public Sale Sale { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotalPrice { get; set; }
        public User User { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<SaleDetail>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.HasOne(e => e.Productid);
                entity.HasOne(e => e.Sale);
                entity.Property(e => e.Quantity).HasColumnType("int").IsRequired();
                entity.Property(e => e.SubTotalPrice).HasColumnType("decimal(10,2)").IsRequired();
                entity.HasOne(e => e.User);
            });
        }
    }
}
