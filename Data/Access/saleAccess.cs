using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access 
{
    public class saleAccess
    {
        DataContext db = new DataContext();
        public IQueryable<sale> GetAll()
        {
            return this.db.sales;
        }

        public sale Find(int id)
        {
            return this.db.sales.Find(id);
        }

        public void Add(sale _sale)
        {
            this.db.sales.Add(_sale);
            this.db.SaveChanges();
        }

        public void Modify(sale _sale)
        {
            this.db.Entry(_sale).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            sale _sale = this.Find(id);
            this.db.sales.Remove(_sale);
            this.db.SaveChanges();
        }

        public int GetTotalBill()
        {
            // Task Complete - Hieu
            // Querry

            int total = 0;
            total = db.sales.Count();
            return total;
        }

        public decimal GetTotalIncome()
        {
            // Task Complete - Hieu
            // Querry

            decimal total = 0;
            var querry = from sale in db.sales
                         select new
                         {
                             salePrice = sale.SaleAnimals.Select(sa => sa.SalePrice)
                         }.salePrice.Sum();

            foreach (var x in querry)
            {
                total += (decimal)(x);
            }

            var querry2 = from sale in db.sales
                             select new
                             {
                               salePrice = sale.SaleMerchandises.Select(sa => sa.SalePrice)
                             }.salePrice.Sum();

            foreach (var x in querry2)
            {
                total += (decimal)(x);
            }
            total = total + (decimal)(db.sales.Sum(sa => sa.SaleTax));

            return total;
        }

        public decimal GetTotalIncomeInMonth(string _year,string _month)
        {
            // Task Complete - Hieu
            // Querry

            decimal total = 0;

            var tax = from i in db.sales
                      where (i.saledate.Month.ToString() == _month && i.saledate.Year.ToString() == _year)
                      select i.SaleTax;
            foreach (var x in tax)
            {
                total += (decimal)(x);
            }

            var animalmoney = from sale in db.sales
                         where (sale.saledate.Month.ToString() == _month && sale.saledate.Year.ToString() == _year)
                         select new
                         {
                             salePrice = sale.SaleAnimals.Select(sa => sa.SalePrice)
                         }.salePrice.Sum();
            foreach (var x in animalmoney)
            {
                total += (decimal)(x);
            }

            var merchandisemoney = from sale in db.sales
                              where (sale.saledate.Month.ToString() == _month && sale.saledate.Year.ToString() == _year)
                              select new
                              {
                                  salePrice = sale.SaleMerchandises.Select(sa => sa.SalePrice)
                              }.salePrice.Sum();
            foreach (var x in merchandisemoney)
            {
                total += (decimal)(x);
            }

            return total;
        }

        public int GetTotalAnimalSalesInMonth(string _year, string _month)
        {
            // Task complete - Huy
            // Querry

            int total = 0;
            var data = from sale in db.sales
                       join animal in db.saleAnimals
                       on sale.ID equals animal.SaleID
                       where
                       sale.saledate.Month.ToString() == _month
                       && sale.saledate.Year.ToString() == _year
                       select new
                       {
                           sale.ID,
                           animal.SaleID,
                       };
            total = data.Count();
            return total;
        }

        public int GetTotalMerchandiseSalesInMonth(string _year, string _month)
        {
            // Task complete - Huy
            // Querry

            int total = 0;
            var data = from sale in db.sales
                       join mechandise in db.saleMerchandises
                       on sale.ID equals mechandise.SaleID
                       where
                       sale.saledate.Month.ToString() == _month
                       && sale.saledate.Year.ToString() == _year
                       select new
                       {
                           sale_ID = sale.ID,
                           mechandise_ID = mechandise.SaleID
                       };
            total = data.Count();
            return total;
        }
        public (string ID, string Phone, string ContactName) GetInfoCusEachSale(sale _sale)
        {
            (string ID, string Phone, string ContactName) data;

            data.ID ="";
            data.Phone = "";
            data.ContactName = "";
            var querry = from s in db.sales
                         join c in db.customers
                         on s.CustomerID equals c.ID
                         where s.ID == _sale.ID
                         select new
                         {
                             ID = c.ID,
                             Phone = c.Phone,
                             ContactName = c.ContactName
                         };
            data.ID = querry.Select(q => q.ID).FirstOrDefault();
            data.Phone = querry.Select(q => q.Phone).FirstOrDefault();
            data.ContactName=querry.Select(q => q.ContactName).FirstOrDefault();
            return data;
        }
        public List<saleAnimal> GetSalePetDetailEachSale (sale _sale)
        {
            List <saleAnimal> list = new List<saleAnimal>();
            var querry = from s in db.sales
                       join sa in db.saleAnimals
                       on s.ID equals sa.SaleID
                       where s.ID == _sale.ID
                       select sa;
            if (querry != null)
            {
                list = querry.ToList<saleAnimal>();
            }
            return list;
        }
        public int GetTotalSalePetEachSale (sale _sale)
        {
            int total = 0;
            total= this.GetSalePetDetailEachSale(_sale).Select(s => s.SaleID).Count();
            return total;
        }
        
        public int GetTotalPetEachSale(sale _sale)
        {
            int total = 0;
            total = this.GetSalePetDetailEachSale(_sale).Select(s => s.AnimalID).Count();
            return total;
        }
    }
}
