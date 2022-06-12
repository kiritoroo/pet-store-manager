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
    public class dalOrderPet
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.OrderPets.Load();
        }

        public ObservableCollection<OrderPet> GetLocal()
        {
            return this.db.OrderPets.Local;
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

        public IQueryable<OrderPet> GetAll()
        {
            return this.db.OrderPets;
        }

        public OrderPet Find(int orderID, string petID)
        {
            return this.db.OrderPets.Find(orderID, petID);
        }

        public void Save(OrderPet orderPet)
        {
            this.db.OrderPets.Add(orderPet);
            this.db.SaveChanges();
        }

        public void Modify(OrderPet orderPet)
        {
            this.db.Entry(orderPet).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int orderID, string petID)
        {
            OrderPet orderPet = this.Find(orderID, petID);
            this.db.OrderPets.Remove(orderPet);
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
