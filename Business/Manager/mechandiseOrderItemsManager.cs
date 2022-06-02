using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
    public class mechandiseOrderItemsManager
    {
        private merchandiseOrderItemAccess dal = new merchandiseOrderItemAccess();

        public IQueryable<merchandiseOrderItem> GetAll()
        {
            return this.dal.GetAll();
        }

        public merchandiseOrderItem Find(int OrderID, string ItemID)
        {
            return this.dal.Find(OrderID, ItemID);
        }

        public void Save(merchandiseOrderItem _merchandiseOrderItem)
        {
            this.dal.Save(_merchandiseOrderItem);
        }

        public void Modify(merchandiseOrderItem _merchandiseOrderItem)
        {
            this.dal.Modify(_merchandiseOrderItem);
        }

        public void Delete(int OrderID, string ItemID)
        {
            this.dal.Delete(OrderID, ItemID);
        }
    }
}

