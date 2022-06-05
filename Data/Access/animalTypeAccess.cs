using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class animalTypeAccess
    {
        DataContext db = new DataContext();
        // CRUD
        public IQueryable<animalType> GetAll()
        {
            return this.db.animalTypes;
        }

        public animalType Find(string id)
        {
            return this.db.animalTypes.Find(id);
        }

        public void Add(animalType _animalType)
        {
            this.db.animalTypes.Add(_animalType);
            this.db.SaveChanges();
        }

        public void Modify(animalType _animalType)
        {
            this.db.Entry(_animalType).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            animalType _animalType = this.Find(id);
            this.db.animalTypes.Remove(_animalType);
            this.db.SaveChanges();
        }

        public List<dynamic> GetStatisticAllAnimal()
        {
            // Task Uncomplete
            //Querry

            List<dynamic> list = new List<dynamic>();
            var querry = default(dynamic);

            if (querry != null)
            {
                list = querry.ToList<dynamic>();
            }
            return list;
        }
    }
}
