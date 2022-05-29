using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class merchandiseOrderMap : EntityTypeConfiguration<merchandiseOrder>
    {
        public merchandiseOrderMap()
        {
            HasKey<int>(mo => mo.ID);
            HasRequired<employee>(mo => mo.Employee)
                        .WithMany(emp => emp.MerchandiseOrders)
                        .HasForeignKey<string>(mo => mo.EmployeeID)
                        .WillCascadeOnDelete(false);
            HasRequired<supplier>(ao => ao.Supplier)
                        .WithMany(supp => supp.MerchandiseOrders)
                        .HasForeignKey<string>(ao => ao.SupplierID)
                        .WillCascadeOnDelete(false);
        }
    }
}
