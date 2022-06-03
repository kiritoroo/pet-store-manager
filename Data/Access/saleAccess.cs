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
            db.Database.Log = Console.Write;
            return this.db.sales;
        }

        public sale Find(int id)
        {
            db.Database.Log = Console.Write;
            return this.db.sales.Find(id);
        }

        public void Add(sale _sale)
        {
            db.Database.Log = Console.Write;
            this.db.sales.Add(_sale);
            this.db.SaveChanges();
        }

        public void Modify(sale _sale)
        {
            db.Database.Log = Console.Write;
            this.db.Entry(_sale).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Database.Log = Console.Write;
            sale _sale = this.Find(id);
            this.db.sales.Remove(_sale);
            this.db.SaveChanges();
        }

        public int GetTotalBill()
        {
            db.Database.Log = Console.Write;
            int total = 0;
            // Task Complete - Hieu
            // Querry
            total = db.sales.Count();
            return total;
        }

        public decimal GetTotalIncome()
        {
            db.Database.Log = Console.Write;
            decimal total = 0;

            // Task Complete - Hieu
            // Querry
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

            db.Database.Log = Console.Write;
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
    }
}
