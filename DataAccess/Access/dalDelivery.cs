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
    public class dalDelivery
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.Deliveries.Load();
        }

        public ObservableCollection<Delivery> GetLocal()
        {
            return this.db.Deliveries.Local;
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

        public IQueryable<Delivery> GetAll()
        {
            return this.db.Deliveries;
        }

        public Delivery Find(int id)
        {
            return this.db.Deliveries.Find(id);
        }

        public void Save(Delivery _employee)
        {
            this.db.Deliveries.Add(_employee);
            this.db.SaveChanges();
        }

        public void Modify(Delivery _employee)
        {
            this.db.Entry(_employee).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            Delivery _employee = this.Find(id);
            this.db.Deliveries.Remove(_employee);
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
