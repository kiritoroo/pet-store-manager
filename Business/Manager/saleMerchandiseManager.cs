using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
    public class saleMerchandiseManager
    {
        private saleMerchandiseAccess dal = new saleMerchandiseAccess();

        public IQueryable<saleMerchandise> GetAll()
        {
            return this.dal.GetAll();
        }

        public saleMerchandise Find(int saleId, string itemId)
        {
            return this.dal.Find(saleId, itemId);
        }

        public void Add(saleMerchandise _saleItem)
        {
            this.dal.Add(_saleItem);
        }

        public void Modify(saleMerchandise _saleItem)
        {
            this.dal.Modify(_saleItem);
        }

        public void Delete(int saleId, string itemId)
        {
            this.dal.Delete(saleId, itemId);
        }

        public int GetTotalMerchandiseSales()
        {
            return this.dal.GetTotalMerchandiseSales();
        }

        public int GetTotalMerchandiseSalesInMonth(string _month)
        {
            return this.dal.GetTotalMerchandiseSalesInMonth(_month);
        }
    }
}
