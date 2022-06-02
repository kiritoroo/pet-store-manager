using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class animalMap : EntityTypeConfiguration<animal>
    {
        public animalMap()
        {
            HasKey<string>(at => at.ID);
            HasRequired<animalType>(a => a.AnimalType)
                .WithMany(at => at.Animals)
                .HasForeignKey<string>(a => a.AnimalTypeID)
                .WillCascadeOnDelete(false);

            Property(p => p.ID)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
