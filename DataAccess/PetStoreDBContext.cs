using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;
using DataAccess.Maps;

namespace DataAccess
{
    public class PetStoreDBContext : DbContext
    {
        public PetStoreDBContext() : base("name=PetStoreDB")
        {
            Database.SetInitializer(new PetStoreDBInitializer());
            Database.Initialize(true);
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PetCategory> PetCategorys { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesPet> SalesPets { get; set; }
        public DbSet<SalesProduct> SalesProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPet> OrderPets { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new mapLogin());
            modelBuilder.Configurations.Add(new mapEmployee());
            modelBuilder.Configurations.Add(new mapCustomer());
            modelBuilder.Configurations.Add(new mapSupplier());
            modelBuilder.Configurations.Add(new mapPetCategory());
            modelBuilder.Configurations.Add(new mapPet());
            modelBuilder.Configurations.Add(new mapProductCategory());
            modelBuilder.Configurations.Add(new mapProduct());
            modelBuilder.Configurations.Add(new mapSales());
            modelBuilder.Configurations.Add(new mapSalesPet());
            modelBuilder.Configurations.Add(new mapSalesProduct());
            modelBuilder.Configurations.Add(new mapOrder());
            modelBuilder.Configurations.Add(new mapOrderPet());
            modelBuilder.Configurations.Add(new mapOrderProduct());
            modelBuilder.Configurations.Add(new mapVoucher());
            modelBuilder.Configurations.Add(new mapDelivery());
        }
    }
}
