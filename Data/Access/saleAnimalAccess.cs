using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class saleAnimalAccess : DataContext
    {
        public IQueryable<saleAnimal> GetAll()
        {
            return this.saleAnimals;
        }

        public saleAnimal Find(int saleId, string animalId)
        {
            return this.saleAnimals.Find(saleId, animalId);
        }

        public void Add(saleAnimal _saleAnimal)
        {
            this.saleAnimals.Add(_saleAnimal);
            this.SaveChanges();
        }

        public void Modify(saleAnimal _saleAnimal)
        {
            Entry(_saleAnimal).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int saleId, string animalId)
        {
            saleAnimal _saleAnimal = this.Find(saleId, animalId);
            saleAnimals.Remove(_saleAnimal);
            SaveChanges();
        }
    }
}
