using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class animalOrderAccess
    {
        DataContext db = new DataContext();
        public IQueryable<animalOrder> GetAll()
        {
            return this.db.animalOrders;
        }

        public animalOrder Find(int id)
        {
            return this.db.animalOrders.Find(id);
        }

        public void Save(animalOrder _animalOrder)
        {
            this.db.animalOrders.Add(_animalOrder);
            this.db.SaveChanges();
        }

        public void Modify(animalOrder _animalOrder)
        {
            this.db.Entry(_animalOrder).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            animalOrder _animalOrder = this.Find(id);
            this.db.animalOrders.Remove(_animalOrder);
            this.db.SaveChanges();
        }
    }
}
