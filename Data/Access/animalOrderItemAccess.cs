using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class animalOrderItemAccess : DataContext
    {
        public IQueryable<animalOrderItem> GetAll()
        {
            return this.animalOrderItems;
        }

        public animalOrderItem Find(int OrderID, string AnimalID)
        {
            return this.animalOrderItems.Find(OrderID, AnimalID);
        }

        public void Save(animalOrderItem _animalOrderItem)
        {
            this.animalOrderItems.Add(_animalOrderItem);
            this.SaveChanges();
        }

        public void Modify(animalOrderItem _animalOrderItem)
        {
            Entry(_animalOrderItem).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int OrderID, string AnimalID)
        {
            animalOrderItem _animalOrderItem = this.Find(OrderID, AnimalID);
            animalOrderItems.Remove(_animalOrderItem);
            SaveChanges();
        }
    }
}
