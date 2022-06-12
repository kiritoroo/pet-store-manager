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
    public class dalVoucher
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.Vouchers.Load();
        }

        public ObservableCollection<Voucher> GetLocal()
        {
            return this.db.Vouchers.Local;
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

        public IQueryable<Voucher> GetAll()
        {
            return this.db.Vouchers;
        }

        public Voucher Find(string id)
        {
            return this.db.Vouchers.Find(id);
        }

        public void Save(Voucher voucher)
        {
            this.db.Vouchers.Add(voucher);
            this.db.SaveChanges();
        }

        public void Modify(Voucher voucher)
        {
            this.db.Entry(voucher).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            Voucher voucher = this.Find(id);
            this.db.Vouchers.Remove(voucher);
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
