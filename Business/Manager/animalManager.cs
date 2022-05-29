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
    public class animalManager
    {
        private DataContext db = new DataContext();

        public IQueryable<animal> GetAll()
        {
            return this.db.animals;
        }

        public List<animal> GetAllList()
        {
            List<animal> list = this.db.animals.ToList();
            return list;
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
            db.Entry(_animal).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            animal _animal = this.Find(id);
            db.animals.Remove(_animal);
            db.SaveChanges();
        }
    }
}
