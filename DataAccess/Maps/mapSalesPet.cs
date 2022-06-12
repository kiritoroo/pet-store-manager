using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapSalesPet : EntityTypeConfiguration<SalesPet>
    {
        public mapSalesPet()
        {
            HasKey(sp => new { sp.SalesID, sp.PetID } );

            HasRequired<Sale>(sp => sp.Sale)
                        .WithMany(s => s.SalesPets)
                        .HasForeignKey<int>(sp => sp.SalesID)
                        .WillCascadeOnDelete(false);

            HasRequired<Pet>(sp => sp.Pet)
                        .WithMany(pet => pet.SalesPets)
                        .HasForeignKey<int>(sp => sp.PetID)
                        .WillCascadeOnDelete(false);
        }
    }
}
