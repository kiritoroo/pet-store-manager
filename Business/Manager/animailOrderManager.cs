using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
    public class animailOrderManager
    {
        private animalOrderAccess dal = new animalOrderAccess();

        public IQueryable<animalOrder> GetAll()
        {
            return this.dal.GetAll();
        }

        public animalOrder Find(int id)
        {
            return this.dal.Find(id);
        }

        public void Save(animalOrder _animalOrder)
        {
            this.dal.Save(_animalOrder);
        }

        public void Modify(animalOrder _animalOrder)
        {
            this.dal.Modify(_animalOrder);
        }

        public void Delete(int id)
        {
            this.dal.Delete(id);
        }
    }
}

