using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class saleMerchandiseMap : EntityTypeConfiguration<saleMerchandise>
    {
        public saleMerchandiseMap()
        {
            HasKey(si => new { si.SaleID, si.MerchandiseID });
            HasRequired<sale>(sa => sa.Sale)
                        .WithMany(s => s.SaleMerchandises)
                        .HasForeignKey<int>(sa => sa.SaleID)
                        .WillCascadeOnDelete(false);
            HasRequired<merchandise>(si => si.Merchandise)
                        .WithMany(m => m.SaleMerchandise)
                        .HasForeignKey<string>(si => si.MerchandiseID)
                        .WillCascadeOnDelete(false);
        }
    }
}
