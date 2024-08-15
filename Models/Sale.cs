using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kasir.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalPrice { get; set; }
        public Costumer? Costumer { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.SaleDate).HasColumnType("date").IsRequired();
                entity.Property(e => e.TotalPrice).HasColumnType("decimal(10,2)").IsRequired();
                entity.HasOne(e => e.Costumer);
            });
        }
    }
}
