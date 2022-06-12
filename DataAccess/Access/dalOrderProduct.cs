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
    public class dalOrderProduct
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.OrderProducts.Load();
        }

        public ObservableCollection<OrderProduct> GetLocal()
        {
            return this.db.OrderProducts.Local;
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

        public IQueryable<OrderProduct> GetAll()
        {
            return this.db.OrderProducts;
        }

        public OrderProduct Find(int orderID, int productID)
        {
            return this.db.OrderProducts.Find(orderID, productID);
        }

        public void Save(OrderProduct orderProduct)
        {
            this.db.OrderProducts.Add(orderProduct);
            this.db.SaveChanges();
        }

        public void Modify(OrderProduct orderProduct)
        {
            this.db.Entry(orderProduct).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int orderID, int productID)
        {
            OrderProduct orderProduct = this.Find(orderID, productID);
            this.db.OrderProducts.Remove(orderProduct);
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
    }
}
