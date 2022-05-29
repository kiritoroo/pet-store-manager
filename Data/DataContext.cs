using System;
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
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Data.Migrations.Configuration>());
        }

        public DbSet<animalType> animalTypes { get; set; }
        public DbSet<animal> animals { get; set; }
        public DbSet<sale> sales { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<employee> employees { get; set; } 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<animal>()
                        .HasRequired<animalType>(a => a.AnimalType)
                        .WithMany(at => at.Animals)
                        .HasForeignKey<string>(a => a.AnimalTypeID);

            modelBuilder.Entity<sale>()
                       .HasRequired<employee>(s => s.Employee)
                       .WithMany(emp => emp.Sales)
                       .HasForeignKey<string>(s => s.EmployeeID);

            modelBuilder.Entity<sale>()
                      .HasRequired<customer>(s => s.Customer)
                      .WithMany(emp => emp.Sales)
                      .HasForeignKey<string>(s => s.CustomerID);

            modelBuilder.Configurations.Add(new animalTypeMap());
            modelBuilder.Configurations.Add(new animalMap());
        }
    }
}
