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
   public  class mechandiseOrderManager
    {
        private DataContext db = new DataContext();

        public IQueryable<merchandiseOrder> FindAll()
        {
            return this.db.merchandiseOrders;
        }

        public merchandiseOrder Find(int id)
        {
            return this.db.merchandiseOrders.Find(id);
        }

        public void Save(merchandiseOrder _merchandiseOrder)
        {
            this.db.merchandiseOrders.Add(_merchandiseOrder);
            this.db.SaveChanges();
        }

        public void Modify(merchandiseOrder _merchandiseOrder)
        {
            db.Entry(_merchandiseOrder).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            merchandiseOrder _merchandiseOrder = this.Find(id);
            db.merchandiseOrders.Remove(_merchandiseOrder);
            db.SaveChanges();
        }
    }
}

