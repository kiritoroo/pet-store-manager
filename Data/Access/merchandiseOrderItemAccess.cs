using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class merchandiseOrderItemAccess
    {
        DataContext db = new DataContext();
        public IQueryable<merchandiseOrderItem> GetAll()
        {
            return this.db.merchandiseOrderItems;
        }

        public merchandiseOrderItem Find(int OrderID, string ItemID)
        {
            return this.db.merchandiseOrderItems.Find(OrderID, ItemID);
        }

        public void Save(merchandiseOrderItem _merchandiseOrderItem)
        {
            this.db.merchandiseOrderItems.Add(_merchandiseOrderItem);
            this.db.SaveChanges();
        }

        public void Modify(merchandiseOrderItem _merchandiseOrderItem)
        {
            this.db.Entry(_merchandiseOrderItem).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int OrderID, string ItemID)
        {
            merchandiseOrderItem _merchandiseOrderItem = this.Find(OrderID, ItemID);
            this.db.merchandiseOrderItems.Remove(_merchandiseOrderItem);
            this.db.SaveChanges();
        }
    }
}
