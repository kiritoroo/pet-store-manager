using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapPet : EntityTypeConfiguration<Pet>
    {
        public mapPet()
        {
            HasKey<int>(pet => pet.ID);

            HasRequired<PetCategory>(pet => pet.PetCategory)
                .WithMany(pc => pc.Pets)
                .HasForeignKey<string>(pet => pet.PetCategoryID)
                .WillCascadeOnDelete(false);
        }
    }
}
