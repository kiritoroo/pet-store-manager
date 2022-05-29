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
    public class saleItemManager
    {
        private DataContext db = new DataContext();

        public IQueryable<saleItem> GetAll()
        {
            return this.db.saleItems;
        }

        public List<saleItem> GetAllList()
        {
            List<saleItem> list = this.db.saleItems.ToList();
            return list;
        }

        public saleItem Find(int saleId, string itemId)
        {
            return this.db.saleItems.Find(saleId, itemId);
        }

        public void Add(saleItem _saleItem)
        {
            this.db.saleItems.Add(_saleItem);
            this.db.SaveChanges();
        }

        public void Modify(saleItem _saleItem)
        {
            db.Entry(_saleItem).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int saleId, string itemId)
        {
            saleItem _saleItem = this.Find(saleId, itemId);
            db.saleItems.Remove(_saleItem);
            db.SaveChanges();
        }
    }
}
