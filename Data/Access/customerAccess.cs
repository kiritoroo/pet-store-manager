using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class customerAccess
    {
        DataContext db = new DataContext();
        public IQueryable<customer> GetAll()
        {
            db.Database.Log = Console.Write;
            return this.db.customers;
        }

        public customer Find(string id)
        {
            db.Database.Log = Console.Write;
            return this.db.customers.Find(id);
        }

        public void Save(customer _customer)
        {
            db.Database.Log = Console.Write;
            this.db.customers.Add(_customer);
            this.db.SaveChanges();
        }

        public void Modify(customer _customer)
        {
            db.Database.Log = Console.Write;
            this.db.Entry(_customer).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            db.Database.Log = Console.Write;
            customer _customer = this.Find(id);
            this.db.customers.Remove(_customer);
            this.db.SaveChanges();
        }
        
        public int GetTotalCustomer()
        {
            db.Database.Log = Console.Write;
            int total = 0;
            // Task Uncomplete
            // Querry

            return total;
        }
    }
}
