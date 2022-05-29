using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class saleItemMap : EntityTypeConfiguration<saleItem>
    {
        public saleItemMap()
        {
            HasKey(si => new { si.SaleID, si.ItemID });
            HasRequired<sale>(sa => sa.Sale)
                        .WithMany(s => s.SaleItems)
                        .HasForeignKey<int>(sa => sa.SaleID)
                        .WillCascadeOnDelete(false);
            HasRequired<merchandise>(si => si.Merchandise)
                        .WithMany(m => m.SaleItems)
                        .HasForeignKey<string>(si => si.ItemID)
                        .WillCascadeOnDelete(false);
        }
    }
}
