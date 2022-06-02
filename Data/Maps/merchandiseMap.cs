using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class merchandiseMap : EntityTypeConfiguration<merchandise>
    {
        public merchandiseMap()
        {
            HasKey<string>(m => m.ID);
            HasRequired<merchandiseType>(m => m.MerchandiseType)
                .WithMany(mt => mt.Merchandises)
                .HasForeignKey<string>(m => m.MerchandiseTypeID)
                .WillCascadeOnDelete(false);

            Property(p => p.ID)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
