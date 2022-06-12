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
    public class dalPet
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.Pets.Load();
        }

        public ObservableCollection<Pet> GetLocal()
        {
            return this.db.Pets.Local;
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

        public IQueryable<Pet> GetAll()
        {
            return this.db.Pets;
        }

        public Pet Find(int id)
        {
            return this.db.Pets.Find(id);
        }

        public void Save(Pet pet)
        {
            this.db.Pets.Add(pet);
            this.db.SaveChanges();
        }

        public void Modify(Pet pet)
        {
            this.db.Entry(pet).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            Pet pet = this.Find(id);
            this.db.Pets.Remove(pet);
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
