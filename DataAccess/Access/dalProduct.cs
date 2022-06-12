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
    public class dalProduct
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.Products.Load();
        }

        public ObservableCollection<Product> GetLocal()
        {
            return this.db.Products.Local;
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

        public IQueryable<Product> GetAll()
        {
            return this.db.Products;
        }

        public Product Find(int id)
        {
            return this.db.Products.Find(id);
        }

        public void Save(Product product)
        {
            this.db.Products.Add(product);
            this.db.SaveChanges();
        }

        public void Modify(Product product)
        {
            this.db.Entry(product).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = this.Find(id);
            this.db.Products.Remove(product);
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
