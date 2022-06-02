using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
    public class animalTypeManager
    {
        private animalTypeAccess dal = new animalTypeAccess();

        public IQueryable<animalType> GetAll()
        {
            return this.dal.GetAll();
        }

        public animalType Find(string id)
        {
            return this.dal.Find(id);
        }

        public void Add(animalType _animalType)
        {
            this.dal.Add(_animalType);
        }

        public void Modify(animalType _animalType)
        {
            this.dal.Modify(_animalType);
        }

        public void Delete(string id)
        {
           this.dal.Delete(id);
        }
    }
}
