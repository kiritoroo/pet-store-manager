using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapOrderPet : EntityTypeConfiguration<OrderPet>
    {
        public mapOrderPet()
        {
            HasKey(odp => new { odp.OrderID, odp.PetID } );

            HasRequired<Order>(odp => odp.Order)
                .WithMany(od => od.OrderPets)
                .HasForeignKey<int>(odp => odp.OrderID)
                .WillCascadeOnDelete(false);

            HasRequired<Pet>(odp => odp.Pet)
                .WithMany(pet => pet.OrderPets)
                .HasForeignKey<int>(odp => odp.PetID)
                .WillCascadeOnDelete(false);
        }    
    }
}
