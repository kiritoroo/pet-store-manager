using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class animalAccess
    {
        DataContext db = new DataContext();
        // CRUD
        public IQueryable<animal> GetAll()
        {
            return this.db.animals;
        }

        public animal Find(string id)
        {
            return this.db.animals.Find(id);
        }

        public void Add(animal _animal)
        {
            this.db.animals.Add(_animal);
            this.db.SaveChanges();
        }

        public void Modify(animal _animal)
        {
            this.db.Entry(_animal).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            animal _animal = this.Find(id);
            this.db.animals.Remove(_animal);
            this.db.SaveChanges();
        }
    }
}
