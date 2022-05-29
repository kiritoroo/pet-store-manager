using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Data.Maps
{
    public class animalOrderMap : EntityTypeConfiguration<animalOrder>
    {
        public animalOrderMap()
        {
            HasKey<int>(ao => ao.ID);
            HasRequired<employee>(ao => ao.Employee)
                .WithMany(emp => emp.AnimalOrders)
                .HasForeignKey<string>(ao => ao.EmployeeID)
                .WillCascadeOnDelete(false);
            HasRequired<supplier>(ao => ao.Supplier)
                .WithMany(supp => supp.AnimalOrders)
                .HasForeignKey<string>(ao => ao.SupplierID)
                .WillCascadeOnDelete(false);
        }
    }
}
