using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
    public class supplierManager
    {
        private supplierAccess dal = new supplierAccess();

        public IQueryable<supplier> GetAll()
        {
            return this.dal.GetAll();
        }

        public supplier Find(string id)
        {
            return this.dal.Find(id);
        }

        public void Save(supplier _supplier)
        {
            this.dal.Save(_supplier);
        }

        public void Modify(supplier _supplier)
        {
            this.dal.Modify(_supplier);
        }

        public void Delete(string id)
        {
            this.dal.Delete(id);
        }

        public int GetTotalSupplier()
        {
            return this.dal.GetTotalSupplier();
        }

        public List<dynamic> GetOrderAnimalDetailEachSupplier(supplier _supplier)
        {
            return this.dal.GetOrderAnimalDetailEachSupplier(_supplier);
        }

        public List<dynamic> GetOrderMerchandiseDetailEachSupplier(supplier _supplier)
        {
            return this.dal.GetOrderMerchandiseDetailEachSupplier(_supplier);
        }

        public int GetTotalOrderAnimalEachSupplier(supplier _supplier)
        {
            return this.dal.GetTotalOrderAnimalEachSupplier(_supplier);
        }

        public decimal GetTotalCostAnimalEachSupplier(supplier _supplier)
        {
            return this.dal.GetTotalCostAnimalEachSupplier(_supplier);
        }

        public int GetTotalOrderMerchandiseEachSupplier(supplier _supplier)
        {
            return this.dal.GetTotalOrderMerchandiseEachSupplier(_supplier);    
        }

        public decimal GetTotalCostMerchandiseEachSupplier(supplier _supplier)
        {
            return this.dal.GetTotalCostMerchandiseEachSupplier(_supplier);
        }
    }
}
