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
    public class animailOderItemManager
    {
        private DataContext db = new DataContext();

        public IQueryable<animalOrderItem> FindAll()
        {
            return this.db.animalOrderItems;
        }

        public animalOrderItem Find(int OrderID,string AnimalID)
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
            db.Entry(_animalOrderItem).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int OrderID, string AnimalID)
        {
            animalOrderItem _animalOrderItem = this.Find(OrderID, AnimalID);
            db.animalOrderItems.Remove(_animalOrderItem);
            db.SaveChanges();
        }
    }
}

