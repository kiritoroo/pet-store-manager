using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class saleMap : EntityTypeConfiguration<sale>
    {
        public saleMap()
        {
            HasKey<int>(s => s.ID);
            HasRequired<employee>(s => s.Employee)
                        .WithMany(emp => emp.Sales)
                        .HasForeignKey<string>(s => s.EmployeeID)
                        .WillCascadeOnDelete(false);
            HasRequired<customer>(s => s.Customer)
                      .WithMany(emp => emp.Sales)
                      .HasForeignKey<string>(s => s.CustomerID)
                      .WillCascadeOnDelete(false);
        }
    }
}
