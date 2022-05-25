using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreManager.Models
{
    public class PetStoreDBEntities: DbContext
    {
        public PetStoreDBEntities(): base("name=PetStoreDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure Domain Classes Here
            base.OnModelCreating(modelBuilder);

            //Fluent API
            modelBuilder.Entity<OrderDetail>()
                .ToTable("OrderDetail")
                .HasKey(e => e.OrderDetailID);
            modelBuilder.Entity<OrderDetail>().Property(p => p.OrderDetailID)
                .IsRequired();
        }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
