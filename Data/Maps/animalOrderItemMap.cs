using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class animalOrderItemMap : EntityTypeConfiguration<animalOrderItem>
    {
        public animalOrderItemMap()
        {
            HasKey(aoi => new { aoi.OrderID, aoi.AnimalID });
            HasRequired<animalOrder>(aoi => aoi.AnimalOrder)
                .WithMany(ao => ao.AnimalOrderItems)
                .HasForeignKey<int>(aoi => aoi.OrderID)
                .WillCascadeOnDelete(false);
            HasRequired<animal>(aoi => aoi.Animal)
                .WithMany(a => a.AnimalOrderItems)
                .HasForeignKey<string>(aoi => aoi.AnimalID)
                .WillCascadeOnDelete(false);
        }
    }
}
