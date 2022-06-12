using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapOrder : EntityTypeConfiguration<Order>
    {
        public mapOrder()
        {
            HasKey<int>(o => o.ID);
            
            HasRequired<Supplier>(o => o.Supplier)
                .WithMany(sup => sup.Orders)
                .HasForeignKey<int>(o => o.SupplierID)
                .WillCascadeOnDelete(false);

            HasRequired<Employee>(o => o.Employee)
                .WithMany(emp => emp.Orders)
                .HasForeignKey<int>(o => o.EmployeeID)
                .WillCascadeOnDelete(false);
        }
    }
}
