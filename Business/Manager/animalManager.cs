using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Data.Access;

namespace Business.Manager
{
    public class animalManager
    {
        private animalAccess dal = new animalAccess();

        public IQueryable<animal> GetAll()
        {
            return this.dal.GetAll();
        }

        public animal Find(string id)
        {
            return this.dal.Find(id);
        }

        public void Add(animal _animal)
        {
            this.dal.Add(_animal);
        }

        public void Modify(animal _animal)
        {
            this.dal.Modify(_animal);
        }

        public void Delete(string id)
        {
            this.dal.Delete(id);
        }
    }
}
