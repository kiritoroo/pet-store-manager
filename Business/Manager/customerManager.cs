using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using Data;
using Entities.Models;
    

namespace Business.Manager
{
    public class customerManager
    {
        private DataContext db = new DataContext();

        public IQueryable<customer> FindAll()
        {
            return this.db.customers;
        }

        public customer Find(string id)
        {
            return this.db.customers.Find(id);
        }

        public void Save(customer _customer)
        {
            this.db.customers.Add(_customer);
            this.db.SaveChanges();
        }

        public void Modify(customer _customer)
        {
            db.Entry(_customer).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            customer _customer = this.Find(id);
            db.customers.Remove(_customer);
            db.SaveChanges();
        }
    }
}
