using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
    public class animailOderItemManager
    {
        private animalOrderItemAccess dal = new animalOrderItemAccess();

        public IQueryable<animalOrderItem> GetAll()
        {
            return this.dal.GetAll();
        }

        public animalOrderItem Find(int OrderID,string AnimalID)
        {
            return this.dal.Find(OrderID, AnimalID);
        }

        public void Save(animalOrderItem _animalOrderItem)
        {
            this.dal.Save(_animalOrderItem);
        }

        public void Modify(animalOrderItem _animalOrderItem)
        {
            this.dal.Modify(_animalOrderItem);
        }

        public void Delete(int OrderID, string AnimalID)
        {
            this.dal.Delete(OrderID, AnimalID);
        }
    }
}

