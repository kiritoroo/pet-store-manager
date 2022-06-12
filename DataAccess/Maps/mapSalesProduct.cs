using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapSalesProduct : EntityTypeConfiguration<SalesProduct>
    {
        public mapSalesProduct()
        {
            HasKey(spr => new { spr.SalesID, spr.ProductID });

            HasRequired<Sale>(spr => spr.Sale)
                        .WithMany(s => s.SalesProducts)
                        .HasForeignKey<int>(spr => spr.SalesID)
                        .WillCascadeOnDelete(false);

            HasRequired<Product>(spr => spr.Product)
                        .WithMany(pro => pro.SalesProducts)
                        .HasForeignKey<int>(spr => spr.ProductID)
                        .WillCascadeOnDelete(false);
        }
    }
}
