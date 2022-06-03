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

        public float GetTotalIncome()
        {
            return this.dal.GetTotalIncome();
        }

        public float GetTotalIncomeInMonth(string _month)
        {
            return this.dal.GetTotalIncomeInMonth(_month);
        }
    }
}
