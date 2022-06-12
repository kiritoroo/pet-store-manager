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
    public class dalOrder
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.Orders.Load();
        }

        public ObservableCollection<Order> GetLocal()
        {
            return this.db.Orders.Local;
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

        public IQueryable<Order> GetAll()
        {
            return this.db.Orders;
        }

        public Order Find(int id)
        {
            return this.db.Orders.Find(id);
        }

        public void Save(Order order)
        {
            this.db.Orders.Add(order);
            this.db.SaveChanges();
        }

        public void Modify(Order order)
        {
            this.db.Entry(order).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            Order order = this.Find(id);
            this.db.Orders.Remove(order);
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
