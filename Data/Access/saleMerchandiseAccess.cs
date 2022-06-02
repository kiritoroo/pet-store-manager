using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class saleMerchandiseAccess : DataContext
    {
        public IQueryable<saleMerchandise> GetAll()
        {
            return this.saleItems;
        }

        public List<saleMerchandise> GetAllList()
        {
            List<saleMerchandise> list = this.saleItems.ToList();
            return list;
        }

        public saleMerchandise Find(int saleId, string itemId)
        {
            return this.saleItems.Find(saleId, itemId);
        }

        public void Add(saleMerchandise _saleItem)
        {
            this.saleItems.Add(_saleItem);
            this.SaveChanges();
        }

        public void Modify(saleMerchandise _saleItem)
        {
            Entry(_saleItem).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int saleId, string itemId)
        {
            saleMerchandise _saleItem = this.Find(saleId, itemId);
            saleItems.Remove(_saleItem);
            SaveChanges();
        }
    }
}
