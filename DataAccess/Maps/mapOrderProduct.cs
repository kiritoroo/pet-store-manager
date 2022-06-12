using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapOrderProduct : EntityTypeConfiguration<OrderProduct>
    {
        public mapOrderProduct()
        {
            HasKey(op => new { op.OrderID, op.ProductID });

            HasRequired<Order>(op => op.Order)
                .WithMany(od => od.OrderProducts)
                .HasForeignKey<int>(op => op.OrderID)
                .WillCascadeOnDelete(false);

            HasRequired<Product>(op => op.Product)
                .WithMany(pro => pro.OrderProducts)
                .HasForeignKey<int>(op => op.ProductID)
                .WillCascadeOnDelete(false);
        }
    }
}
