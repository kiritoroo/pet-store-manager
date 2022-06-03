using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class merchandiseOrderAccess
    {
        DataContext db = new DataContext();
        public IQueryable<merchandiseOrder> GetAll()
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
            this.db.Entry(_merchandiseOrder).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            merchandiseOrder _merchandiseOrder = this.Find(id);
            this.db.merchandiseOrders.Remove(_merchandiseOrder);
            this.db.SaveChanges();
        }
    }
}
