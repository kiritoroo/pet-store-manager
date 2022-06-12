using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.ObjectModel;

namespace DataAccess.Access
{
    public class dalCustomer
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.Customers.Load();
        }

        public ObservableCollection<Customer> GetLocal()
        {
            return this.db.Customers.Local;
        }

        public void SaveLocal()
        {
            this.db.SaveChanges();
        }

        public List<DbEntityEntry> GetChangeTracker()
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != System.Data.Entity.EntityState.Unchanged).ToList();
            return changed;
        }

        public IQueryable<Customer> GetAll()
        {
            return this.db.Customers;
        }

        public Customer Find(int id)
        {
            return this.db.Customers.Find(id);
        }

        public void Save(Customer customer)
        {
            this.db.Customers.Add(customer);
            this.db.SaveChanges();
        }

        public void Modify(Customer customer)
        {
            this.db.Entry(customer).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            Customer customer = this.Find(id);
            this.db.Customers.Remove(customer);
            this.db.SaveChanges();
        }

        public void CancelChanged()
        {
            var changed = this.GetChangeTracker();
            foreach (var obj in changed)
            {
                switch (obj.State)
                {
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        obj.State = EntityState.Unchanged;
                        break;
                }
            }
        }

        public int GetTotalCustomer()
        {
            // Task Complete  - Hieu
            // Querry
            int total = 0;
            total = db.Customers.Count();
            return total;
        }

        public int GetTotalCustomerInMonth(string _year, string _month)
        {
            // Task Complete - Trung
            // Querry
            int total = 0;
            var querry = (from customer in db.Customers
                          where customer.AddDate.Month.ToString() == _month
                          && customer.AddDate.Year.ToString() == _year
                          select customer);
            total = querry.Count();
            return total;
        }

        public List<dynamic> GetSalePetDetailEachCustomer(Customer customer)
        {
            // Task Complete advance - Huy
            // Querry
            List<dynamic> list = new List<dynamic>();
            var data = (from c in db.Customers
                        join s in db.Sales on c.ID equals s.CustomerID
                        join sa in db.SalesPets on s.ID equals sa.SalesID
                        where c.ID == customer.ID
                        select new
                        {
                            s.CustomerID,
                            s.SaleDate,
                            s.ID,
                            sa.PetID,
                            sa.Price
                        }).DefaultIfEmpty();

            var querry = from q in data
                         group q by new { q.ID, q.CustomerID, q.SaleDate } into gr
                         where gr.Count() > 0
                         select new
                         {
                             SaleID = gr.Key.ID,
                             Date = gr.Key.SaleDate,
                             TotalAnimals = gr.Count(),
                             TotalMoney = gr.Sum(x => x.Price)
                         };
            list = querry.ToList<dynamic>();

            return list;
        }

        public List<dynamic> GetSaleProductDetailEachCustomer(Customer customer)
        {
            // Task Complete advance - Huy
            // Querry
            List<dynamic> list = new List<dynamic>();
            var data = from c in db.Customers
                       join s in db.Sales on c.ID equals s.CustomerID
                       join sa in db.SalesProducts on s.ID equals sa.SalesID
                       where c.ID == customer.ID

                       select new
                       {
                           s.CustomerID,
                           s.SaleDate,
                           s.ID,
                           sa.Quantity,
                           sa.UnitPrice
                       };

            var querry = from q in data
                         group q by new { q.ID, q.CustomerID, q.SaleDate }
                         into gr
                         select new
                         {
                             SaleID = gr.Key.ID,
                             Date = gr.Key.SaleDate,
                             TotalItems = gr.Sum(z => z.Quantity),
                             TotalMoney = gr.Sum(x => x.UnitPrice * x.Quantity)
                         };
            list = querry.ToList<dynamic>();

            return list;
        }

        public int GetTotalSalePetEachCustomer(Customer customer)
        {
            // Task Complete - Huy
            // Querry
            int total = 0;
            var data = from c in db.Customers
                       join s in db.Sales on c.ID equals s.CustomerID
                       join sa in db.SalesPets on s.ID equals sa.SalesID
                       where c.ID == customer.ID
                       select sa.PetID;
            total = data.DefaultIfEmpty(0).Count();
            return total;
        }

        public decimal GetTotalMoneyPetEachCustomer(Customer customer)
        {
            // Task Complete - Huy
            // Querry
            var data = from c in db.Customers
                       join s in db.Sales on c.ID equals s.CustomerID
                       join sa in db.SalesPets on s.ID equals sa.SalesID
                       where c.ID == customer.ID
                       select sa.Price;
            decimal total = (decimal)data.DefaultIfEmpty(0).Sum();
            return total;
        }

        public int GetTotalSaleProductEachCustomer(Customer customer)
        {
            // Task Complete - Huy
            // Querry
            int total = 0;
            var data = from c in db.Customers
                       join s in db.Sales on c.ID equals s.CustomerID
                       join sa in db.SalesProducts on s.ID equals sa.SalesID
                       where c.ID == customer.ID
                       select sa.Quantity;
            total = data.DefaultIfEmpty(0).Sum();
            return total;
        }

        public decimal GetTotalMoneyProductEachCustomer(Customer customer)
        {
            // Task Complete - Huy
            // Querry
            decimal total = 0;
            var data = from c in db.Customers
                       join s in db.Sales on c.ID equals s.CustomerID
                       join sa in db.SalesProducts on s.ID equals sa.SalesID
                       where c.ID == customer.ID
                       select sa.UnitPrice * sa.Quantity;
            total = (decimal)data.DefaultIfEmpty(0).Sum();

            return total;
        }
    }
}
