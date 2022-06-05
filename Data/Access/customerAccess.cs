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
            this.db.Entry(_customer).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            customer _customer = this.Find(id);
            this.db.customers.Remove(_customer);
            this.db.SaveChanges();
        }

        public int GetTotalCustomer()
        {
            // Task Complete - Hieu
            // Querry

            int total = 0;
            total = db.customers.Count();
            return total;
        }
        public int GetTotalCustomerInMonth(string _year, string _month)
        {
            // Task Uncomplete
            // Querry

            int total = 0;

            return total;
        }

        public List<dynamic> GetSaleAnimalDetailEachCustomer(customer _customer)
        {
            // Task Uncomplete
            // Querry

            List<dynamic> list = new List<dynamic>();
            var querry = default(dynamic);

            if (querry != null)
            {
                list = querry.ToList<dynamic>();
            }
            return list;
        }

        public List<dynamic> GetSaleMerchandiseDetailEachCustomer(customer _customer)
        {
            // Task Uncomplete
            // Querry

            List<dynamic> list = new List<dynamic>();
            var querry = default(dynamic);

            if (querry != null)
            {
                list = querry.ToList<dynamic>();
            }
            return list;
        }

        public int GetTotalSaleAnimalEachCustomer(customer _customer)
        {
            // Task Uncomplete
            // Querry
            int total = 0;

            return total;
        }

        public decimal GetTotalMoneyAnimalEachCustomer(customer _customer)
        {
            // Task Uncomplete
            // Querry

            decimal total = 0;

            return total;
        }

        public int GetTotalSaleMerchandiseEachCustomer(customer _customer)
        {
            // Task Uncomplete
            // Querry

            int total = 0;

            return total;
        }

        public decimal GetTotalMoneyMerchandiseEachCustomer(customer _customer)
        {
            // Task Uncomplete
            // Querry

            decimal total = 0;

            return total;
        }
    }
}
