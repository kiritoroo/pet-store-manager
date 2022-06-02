using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class customerAccess : DataContext
    {
        public IQueryable<customer> GetAll()
        {
            return this.customers;
        }

        public customer Find(string id)
        {
            return this.customers.Find(id);
        }

        public void Save(customer _customer)
        {
            this.customers.Add(_customer);
            this.SaveChanges();
        }

        public void Modify(customer _customer)
        {
            Entry(_customer).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(string id)
        {
            customer _customer = this.Find(id);
            customers.Remove(_customer);
            SaveChanges();
        }
    }
}
