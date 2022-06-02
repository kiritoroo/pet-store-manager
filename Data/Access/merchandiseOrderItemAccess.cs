using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class merchandiseOrderItemAccess : DataContext
    {
        public IQueryable<merchandiseOrderItem> GetAll()
        {
            return this.merchandiseOrderItems;
        }

        public merchandiseOrderItem Find(int OrderID, string ItemID)
        {
            return this.merchandiseOrderItems.Find(OrderID, ItemID);
        }

        public void Save(merchandiseOrderItem _merchandiseOrderItem)
        {
            this.merchandiseOrderItems.Add(_merchandiseOrderItem);
            this.SaveChanges();
        }

        public void Modify(merchandiseOrderItem _merchandiseOrderItem)
        {
            Entry(_merchandiseOrderItem).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int OrderID, string ItemID)
        {
            merchandiseOrderItem _merchandiseOrderItem = this.Find(OrderID, ItemID);
            merchandiseOrderItems.Remove(_merchandiseOrderItem);
            SaveChanges();
        }
    }
}
