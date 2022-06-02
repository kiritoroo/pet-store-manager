using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class merchandiseOrderAccess : DataContext
    {
        public IQueryable<merchandiseOrder> GetAll()
        {
            return this.merchandiseOrders;
        }

        public merchandiseOrder Find(int id)
        {
            return this.merchandiseOrders.Find(id);
        }

        public void Save(merchandiseOrder _merchandiseOrder)
        {
            this.merchandiseOrders.Add(_merchandiseOrder);
            this.SaveChanges();
        }

        public void Modify(merchandiseOrder _merchandiseOrder)
        {
            Entry(_merchandiseOrder).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int id)
        {
            merchandiseOrder _merchandiseOrder = this.Find(id);
            merchandiseOrders.Remove(_merchandiseOrder);
            SaveChanges();
        }
    }
}
