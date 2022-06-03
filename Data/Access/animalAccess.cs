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
            db.Database.Log = Console.Write;
            return this.db.animals;
        }

        public animal Find(string id)
        {
            db.Database.Log = Console.Write;
            return this.db.animals.Find(id);
        }

        public void Add(animal _animal)
        {
            db.Database.Log = Console.Write;
            this.db.animals.Add(_animal);
            this.db.SaveChanges();
        }

        public void Modify(animal _animal)
        {
            db.Database.Log = Console.Write;
            this.db.Entry(_animal).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            db.Database.Log = Console.Write;
            animal _animal = this.Find(id);
            this.db.animals.Remove(_animal);
            this.db.SaveChanges();
        }
    }
}
