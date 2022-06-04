using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class saleMerchandiseAccess
    {
        DataContext db = new DataContext();
        public IQueryable<saleMerchandise> GetAll()
        {
            return this.db.saleMerchandises;
        }

        public List<saleMerchandise> GetAllList()
        {
            List<saleMerchandise> list = this.db.saleMerchandises.ToList();
            return list;
        }

        public saleMerchandise Find(int saleId, string itemId)
        {
            return this.db.saleMerchandises.Find(saleId, itemId);
        }

        public void Add(saleMerchandise _saleItem)
        {
            this.db.saleMerchandises.Add(_saleItem);
            this.db.SaveChanges();
        }

        public void Modify(saleMerchandise _saleItem)
        {
            this.db.Entry(_saleItem).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int saleId, string itemId)
        {
            saleMerchandise _saleItem = this.Find(saleId, itemId);
            this.db.saleMerchandises.Remove(_saleItem);
            this.db.SaveChanges();
        }

        public int GetTotalMerchandiseSales()
        {
            // Task Uncomplete - Huy
            // Querry

            int total = 0;
            var data = from saleMerchandise in db.saleMerchandises
                       select saleMerchandise;

            total = data.Count();
            return total;
        }
    }
}
