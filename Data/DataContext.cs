﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Entities.Models;
using Data.Maps;


namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=PetStoreDB")
        {
            Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Data.Migrations.Configuration>());
        }

        public DbSet<animalType> animalTypes { get; set; }
        public DbSet<animal> animals { get; set; }
        public DbSet<merchandise> merchandises { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<employee> employees { get; set; }
        public DbSet<supplier> suppliers { get; set; }
        public DbSet<sale> sales { get; set; }
        public DbSet<saleAnimal> saleAnimals { get; set; }
        public DbSet<saleItem> saleItems { get; set; }
        public DbSet<animalOrder> animalOrders { get; set; }
        public DbSet<animalOrderItem> animalOrderItems { get; set; }
        public DbSet<merchandiseOrder> merchandiseOrders { get; set; }
        public DbSet<merchandiseOrderItem> merchandiseOrderItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new animalTypeMap());
            modelBuilder.Configurations.Add(new animalMap());
            modelBuilder.Configurations.Add(new merchandiseMap());
            modelBuilder.Configurations.Add(new customerMap());
            modelBuilder.Configurations.Add(new employeeMap());
            modelBuilder.Configurations.Add(new supplierMap());
            modelBuilder.Configurations.Add(new saleMap());
            modelBuilder.Configurations.Add(new saleAnimalMap());
            modelBuilder.Configurations.Add(new saleItemMap());
            modelBuilder.Configurations.Add(new animalOrderMap());
            modelBuilder.Configurations.Add(new animalOrderItemMap());
            modelBuilder.Configurations.Add(new merchandiseOrderMap());
            modelBuilder.Configurations.Add(new merchandiseOrderItemMap());
        }
    }
}