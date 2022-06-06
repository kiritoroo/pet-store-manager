using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Data.Access;

namespace Business.Manager
{
    public class saleManager
    {
        private saleAccess dal = new saleAccess();

        public IQueryable<sale> GetAll()
        {
            return this.dal.GetAll();
        }

        public sale Find(int id)
        {
            return this.dal.Find(id);
        }

        public void Add(sale _sale)
        {
            this.dal.Add(_sale);
        }

        public void Modify(sale _sale)
        {
            this.dal.Modify(_sale);
        }

        public void Delete(int id)
        {
            this.dal.Delete(id);
        }

        public int GetTotalBill()
        {
            return this.dal.GetTotalBill();
        }

        public decimal GetTotalIncome()
        {
            return this.dal.GetTotalIncome();
        }

        public decimal GetTotalIncomeInMonth(string _year, string _month)
        {
            return this.dal.GetTotalIncomeInMonth(_year,_month);
        }

        public int GetTotalAnimalSalesInMonth(string _year, string _month)
        {
            int total = this.dal.GetTotalAnimalSalesInMonth(_year, _month);
            return total;
        }

        public int GetTotalMerchandiseSalesInMonth(string _year, string _month)
        {
            return this.dal.GetTotalMerchandiseSalesInMonth(_year, _month);
        }

        public (string ID, string Phone, string ContactName) GetInfoCusEachSale(sale _sale)
        {
            return this.dal.GetInfoCusEachSale(_sale);
        }
        public List<saleAnimal> GetSalePetDetailEachSale(sale _sale)
        {
            return this.dal.GetSalePetDetailEachSale(_sale);
        }
        public int GetTotalSalePetEachSale(sale _sale)
        {
            return this.dal.GetTotalSalePetEachSale(_sale);
        }
        public int GetTotalPetEachSale(sale _sale)
        {
            return this.dal.GetTotalPetEachSale(_sale);
        }
      
    }
}
