using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class animalAccess : DataContext
    {
        // CRUD
        public IQueryable<animal> GetAll()
        {
            return this.animals;
        }

        public animal Find(string id)
        {
            return this.animals.Find(id);
        }

        public void Add(animal _animal)
        {
            this.animals.Add(_animal);
            this.SaveChanges();
        }

        public void Modify(animal _animal)
        {
            Entry(_animal).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(string id)
        {
            animal _animal = this.Find(id);
            animals.Remove(_animal);
            SaveChanges();
        }
    }
}
