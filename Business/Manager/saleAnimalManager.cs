using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data;
using Entities.Models;

namespace Business.Manager
{
    public class saleAnimalManager
    {
        private DataContext db = new DataContext();

        public IQueryable<saleAnimal> GetAll()
        {
            return this.db.saleAnimals;
        }

        public List<saleAnimal> GetAllList()
        {
            List<saleAnimal> list = this.db.saleAnimals.ToList();
            return list;
        }

        public saleAnimal Find(int saleId, string animalId)
        {
            return this.db.saleAnimals.Find(saleId, animalId);
        }

        public void Add(saleAnimal _saleAnimal)
        {
            this.db.saleAnimals.Add(_saleAnimal);
            this.db.SaveChanges();
        }

        public void Modify(saleAnimal _saleAnimal)
        {
            db.Entry(_saleAnimal).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int saleId, string animalId)
        {
            saleAnimal _saleAnimal = this.Find(saleId, animalId);
            db.saleAnimals.Remove(_saleAnimal);
            db.SaveChanges();
        }
    }
}
