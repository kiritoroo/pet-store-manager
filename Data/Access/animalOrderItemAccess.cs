using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class animalOrderItemAccess
    {
        DataContext db = new DataContext();
        public IQueryable<animalOrderItem> GetAll()
        {
            return this.db.animalOrderItems;
        }

        public animalOrderItem Find(int OrderID, string AnimalID)
        {
            return this.db.animalOrderItems.Find(OrderID, AnimalID);
        }

        public void Save(animalOrderItem _animalOrderItem)
        {
            this.db.animalOrderItems.Add(_animalOrderItem);
            this.db.SaveChanges();
        }

        public void Modify(animalOrderItem _animalOrderItem)
        {
            this.db.Entry(_animalOrderItem).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int OrderID, string AnimalID)
        {
            animalOrderItem _animalOrderItem = this.Find(OrderID, AnimalID);
            this.db.animalOrderItems.Remove(_animalOrderItem);
            this.db.SaveChanges();
        }
    }
}
