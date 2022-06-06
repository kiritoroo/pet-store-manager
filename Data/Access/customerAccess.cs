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
            // Task Complete 
            // Querry

            int total = 0;
            total = db.customers.Count();
            return total;
        }
        public int GetTotalCustomerInMonth(string _year, string _month)
        {
            // Task complete
            // Querry
            var toal_cus_inmoth =from c in db.customers 
                  join  s in db.sales on  c.ID equals s.CustomerID
                  where s.saledate.Year.ToString()== _year  
                  && s.saledate.Month.ToString()== _month
                  select c.ID;
            int total = toal_cus_inmoth.Count();
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

        public  int GetTotalSaleAnimalEachCustomer(customer _customer)
        {
            // Task complete
            // Querry
            var data = from c in db.customers
                       join s in db.sales on c.ID equals s.CustomerID
                       join sa in db.saleAnimals on s.ID equals sa.SaleID
                       where c.ID == _customer.ID
                       select sa.AnimalID;
            int  total = data.Count();
            return total;
        }

        public decimal GetTotalMoneyAnimalEachCustomer(customer _customer)
        {
            // Task complete
            // Querry
            var data = from c in db.customers
                       join s in db.sales on c.ID equals s.CustomerID
                       join sa in db.saleAnimals on s.ID equals sa.SaleID
                       where c.ID == _customer.ID
                       select sa.SalePrice;
            decimal total = (decimal)data.Sum();
            return total;
        }

        public int GetTotalSaleMerchandiseEachCustomer(customer _customer)
        {
            // Task complete
            // Querry

            var data = from c in db.customers
                       join s in db.sales on c.ID equals s.CustomerID
                       join sa in db.saleMerchandises on s.ID equals sa.SaleID
                       where c.ID == _customer.ID
                       select sa.MerchandiseID;
            int total = data.Count();
            return total;
        }

        public decimal GetTotalMoneyMerchandiseEachCustomer(customer _customer)
        {
            // Task Uncomplete
            // Querry

            var data = from c in db.customers
                       join s in db.sales on c.ID equals s.CustomerID
                       join sa in db.saleMerchandises on s.ID equals sa.SaleID
                       where c.ID == _customer.ID
                       select sa.SalePrice;
            decimal total = (decimal)data.Sum();

            return total;
        }
    }
}
