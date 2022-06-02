using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class animalTypeAccess : DataContext
    {
        // CRUD
        public IQueryable<animalType> GetAll()
        {
            return this.animalTypes;
        }

        public animalType Find(string id)
        {
            return this.animalTypes.Find(id);
        }

        public void Add(animalType _animalType)
        {
            this.animalTypes.Add(_animalType);
            this.SaveChanges();
        }

        public void Modify(animalType _animalType)
        {
            Entry(_animalType).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(string id)
        {
            animalType _animalType = this.Find(id);
            animalTypes.Remove(_animalType);
            SaveChanges();
        }
    }
}
