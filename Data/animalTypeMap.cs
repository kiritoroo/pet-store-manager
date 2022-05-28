using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities;

namespace Data
{
    public class animalTypeMap:
                    EntityTypeConfiguration<animalType>
    {
        public animalTypeMap()
        {
            Property(p => p.ID)
                .IsRequired()
                .HasMaxLength(10);
            Property(p => p.Description)
                .IsOptional();
        }
    }
}
