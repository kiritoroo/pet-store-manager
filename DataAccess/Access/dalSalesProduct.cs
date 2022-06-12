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
    public class dalSalesProduct
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.SalesProducts.Load();
        }

        public ObservableCollection<SalesProduct> GetLocal()
        {
            return this.db.SalesProducts.Local;
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

        public IQueryable<SalesProduct> GetAll()
        {
            return this.db.SalesProducts;
        }

        public SalesProduct Find(int saleID, int productID)
        {
            return this.db.SalesProducts.Find(saleID, productID);
        }

        public void Save(SalesProduct salesProduct)
        {
            this.db.SalesProducts.Add(salesProduct);
            this.db.SaveChanges();
        }

        public void Modify(SalesProduct salesProduct)
        {
            this.db.Entry(salesProduct).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int saleID, int productID)
        {
            SalesProduct salesProduct = this.Find(saleID, productID);
            this.db.SalesProducts.Remove(salesProduct);
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

        public int GetTotalProductSales()
        {
            // Task Complete - Huy
            // Querry

            int total = 0;
            var data = from saleMerchandise in db.SalesProducts
                       select saleMerchandise;

            total = data.Count();
            return total;
        }
    }
}
