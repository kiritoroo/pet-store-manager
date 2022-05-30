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
    public class mechandiseOrderItemsManager
    {
        private DataContext db = new DataContext();

        public IQueryable<merchandiseOrderItem> FindAll()
        {
            return this.db.merchandiseOrderItems;
        }

        public merchandiseOrderItem Find(int OrderID, string ItemID)
        {
            return this.db.merchandiseOrderItems.Find(OrderID,ItemID);
        }

        public void Save(merchandiseOrderItem _merchandiseOrderItem)
        {
            this.db.merchandiseOrderItems.Add(_merchandiseOrderItem);
            this.db.SaveChanges();
        }

        public void Modify(merchandiseOrderItem _merchandiseOrderItem)
        {
            db.Entry(_merchandiseOrderItem).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int OrderID, string ItemID)
        {
           merchandiseOrderItem _merchandiseOrderItem = this.Find(OrderID, ItemID);
            db.merchandiseOrderItems.Remove(_merchandiseOrderItem);
            db.SaveChanges();
        }
    }
}

