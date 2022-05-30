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
    public class animailOrderManager
    {
        private DataContext db = new DataContext();

        public IQueryable<animalOrder> FindAll()
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
            db.Entry(_animalOrder).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            animalOrder _animalOrder = this.Find(id);
            db.animalOrders.Remove(_animalOrder);
            db.SaveChanges();
        }
    }
}

