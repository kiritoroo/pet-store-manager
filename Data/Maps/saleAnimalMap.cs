using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class saleAnimalMap : EntityTypeConfiguration<saleAnimal>
    {
        public saleAnimalMap()
        {
            HasKey(sa => new { sa.SaleID, sa.AnimalID });
            HasRequired<sale>(sa => sa.Sale)
                        .WithMany(s => s.SaleAnimals)
                        .HasForeignKey<int>(sa => sa.SaleID)
                        .WillCascadeOnDelete(false);
            HasRequired<animal>(sa => sa.Animal)
                        .WithMany(a => a.SaleAnimals)
                        .HasForeignKey<string>(sa => sa.AnimalID)
                        .WillCascadeOnDelete(false);
        }
    }
}
