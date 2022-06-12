using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapSales : EntityTypeConfiguration<Sale>
    {
        public mapSales()
        {
            HasKey<int>(sal => sal.ID);

            HasRequired<Customer>(sal => sal.Customer)
                .WithMany(cus => cus.Sales)
                .HasForeignKey<int>(sal => sal.CustomerID)
                .WillCascadeOnDelete(false);

            HasRequired<Employee>(sal => sal.Employee)
                .WithMany(emp => emp.Sales)
                .HasForeignKey<int>(sal => sal.EmployeeID)
                .WillCascadeOnDelete(false);

            HasOptional<Voucher>(sal => sal.Voucher)
                .WithMany(vou => vou.Sales)
                .HasForeignKey<string>(sal => sal.VoucherCode)
                .WillCascadeOnDelete(false);

            HasOptional<Delivery>(sal => sal.Delivery)
                .WithRequired(del => del.Sale)
                .WillCascadeOnDelete(false);

            Property(sal => sal.VoucherCode)
                .IsOptional();
        }
    }
}
