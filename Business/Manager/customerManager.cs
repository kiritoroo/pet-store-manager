using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;
    

namespace Business.Manager
{
    public class customerManager
    {
        private customerAccess dal = new customerAccess();

        public IQueryable<customer> GetAll()
        {
            return this.dal.GetAll();
        }

        public customer Find(string id)
        {
            return this.dal.Find(id);
        }

        public void Save(customer _customer)
        {
            this.dal.Save(_customer);
        }

        public void Modify(customer _customer)
        {
            this.dal.Modify(_customer);
        }

        public void Delete(string id)
        {
            this.dal.Delete(id);
        }

        public int GetTotalCustomer()
        {
            return this.dal.GetTotalCustomer();
        }

        public int GetTotalCustomerInMonth(string _year, string _month)
        {
            return this.dal.GetTotalCustomerInMonth(_year, _month);
        }

        public List<dynamic> GetSaleAnimalDetailEachCustomer(customer _customer)
        {
            return this.dal.GetSaleAnimalDetailEachCustomer(_customer);
        }

        public List<dynamic> GetSaleMerchandiseDetailEachCustomer(customer _customer)
        {
            return this.dal.GetSaleMerchandiseDetailEachCustomer(_customer);
        }

        public int GetTotalSaleAnimalEachCustomer(customer _customer)
        {
            int total = this.dal.GetTotalSaleAnimalEachCustomer(_customer);
            return total;
        }

        public decimal GetTotalMoneyAnimalEachCustomer(customer _customer)
        {
            decimal total = this.dal.GetTotalMoneyAnimalEachCustomer(_customer);
            return total;
        }

        public int GetTotalSaleMerchandiseEachCustomer(customer _customer)
        {
            int total = this.dal.GetTotalSaleMerchandiseEachCustomer(_customer);
            return total;
        }

        public decimal GetTotalMoneyMerchandiseEachCustomer(customer _customer)
        {
            decimal total = this.dal.GetTotalMoneyMerchandiseEachCustomer(_customer);
            return total;
        }
    }
}
