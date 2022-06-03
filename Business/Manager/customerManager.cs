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
    }
}
