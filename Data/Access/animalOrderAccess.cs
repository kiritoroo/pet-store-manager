using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class animalOrderAccess : DataContext
    {
        public IQueryable<animalOrder> GetAll()
        {
            return this.animalOrders;
        }

        public animalOrder Find(int id)
        {
            return this.animalOrders.Find(id);
        }

        public void Save(animalOrder _animalOrder)
        {
            this.animalOrders.Add(_animalOrder);
            this.SaveChanges();
        }

        public void Modify(animalOrder _animalOrder)
        {
            Entry(_animalOrder).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int id)
        {
            animalOrder _animalOrder = this.Find(id);
            animalOrders.Remove(_animalOrder);
            SaveChanges();
        }
    }
}
