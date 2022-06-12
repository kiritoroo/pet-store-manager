using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.ObjectModel;

namespace DataAccess.Access
{
    public class dalSalesPet
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.SalesPets.Load();
        }

        public ObservableCollection<SalesPet> GetLocal()
        {
            return this.db.SalesPets.Local;
        }

        public void SaveLocal()
        {
            this.db.SaveChanges();
        }

        public List<DbEntityEntry> GetChangeTracker()
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != System.Data.Entity.EntityState.Unchanged).ToList();
            return changed;
        }

        public IQueryable<SalesPet> GetAll()
        {
            return this.db.SalesPets;
        }

        public SalesPet Find(int saleID, int petID)
        {
            return this.db.SalesPets.Find(saleID, petID);
        }

        public void Save(SalesPet salesPet)
        {
            this.db.SalesPets.Add(salesPet);
            this.db.SaveChanges();
        }

        public void Modify(SalesPet salesPet)
        {
            this.db.Entry(salesPet).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int saleID, int petID)
        {
            SalesPet salesPet = this.Find(saleID, petID);
            this.db.SalesPets.Remove(salesPet);
            this.db.SaveChanges();
        }

        public void CancelChanged()
        {
            var changed = this.GetChangeTracker();
            foreach (var obj in changed)
            {
                switch (obj.State)
                {
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        obj.State = EntityState.Unchanged;
                        break;
                }
            }
        }

        public int GetTotalPetSales()
        {
            // Task Complete - Huy
            // Querry

            int total = 0;
            var data = from saleAnimal in db.SalesPets
                       select saleAnimal;

            total = data.Count();
            return total;
        }
    }
}
