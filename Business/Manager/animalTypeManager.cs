using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using Data;
using Entities.Models;

namespace Business.Manager
{
    public class animalTypeManager
    {
        private DataContext db = new DataContext();

        public IQueryable<animalType> FindAll()
        {
            return this.db.animalTypes;
        }

        public animalType Find(string id)
        {
            return this.db.animalTypes.Find(id);
        }

        public void Save(animalType _animalType)
        {
            this.db.animalTypes.Add(_animalType);
            this.db.SaveChanges();
        }

        public void Modify(animalType _animalType)
        {
            db.Entry(_animalType).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            animalType _animalType = this.Find(id);
            db.animalTypes.Remove(_animalType);
            db.SaveChanges();
        }
    }
}
