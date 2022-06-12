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
    public class dalSales
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.Sales.Load();
        }

        public ObservableCollection<Sale> GetLocal()
        {
            return this.db.Sales.Local;
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

        public IQueryable<Sale> GetAll()
        {
            return this.db.Sales;
        }

        public Sale Find(int id)
        {
            return this.db.Sales.Find(id);
        }

        public void Save(Sale sale)
        {
            this.db.Sales.Add(sale);
            this.db.SaveChanges();
        }

        public void Modify(Sale sale)
        {
            this.db.Entry(sale).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            Sale sale = this.Find(id);
            this.db.Sales.Remove(sale);
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

        public decimal GetTotalIncome()
        {
            // Task Complete - Hieu
            // Querry

            decimal total = 0;
            var querry = from sale in db.Sales
                         select new
                         {
                             salePrice = sale.SalesPets.Select(sa => sa.Price)
                         }.salePrice.DefaultIfEmpty(0f).Sum();
            foreach (var x in querry)
            {
                total += (decimal)(x);
            }

            var querry2 = from sale in db.Sales
                          select new
                          {
                              salePrice = sale.SalesProducts.Select(sp => sp.UnitPrice * sp.Quantity)
                          }.salePrice.DefaultIfEmpty(0f).Sum();
            foreach (var x in querry2)
            {
                total += (decimal)(x);
            }
            total = total + (decimal)(db.Sales.Sum(sa => sa.SaleTax));

            return total;
        }

        public decimal GetTotalIncomeInMonth(string _year, string _month)
        {
            // Task Complete - Hieu
            // Querry

            decimal total = 0;

            var tax = from i in db.Sales
                      where (i.SaleDate.Month.ToString() == _month && i.SaleDate.Year.ToString() == _year)
                      select i.SaleTax;
            foreach (var x in tax)
            {
                total += (decimal)(x);
            }

            var animalmoney = from sale in db.Sales
                              where (sale.SaleDate.Month.ToString() == _month && sale.SaleDate.Year.ToString() == _year)
                              select new
                              {
                                  Price = sale.SalesPets.Select(sa => sa.Price) 
                                }.Price.DefaultIfEmpty(0f).Sum();
            foreach (var x in animalmoney)
            {
                total += (decimal)(x);
            }

            var merchandisemoney = from sale in db.Sales
                                   where (sale.SaleDate.Month.ToString() == _month && sale.SaleDate.Year.ToString() == _year)
                                   select new
                                   {
                                       salePrice = sale.SalesProducts.Select(sp => sp.UnitPrice * sp.Quantity)
                                   }.salePrice.DefaultIfEmpty(0f).Sum();
            foreach (var x in merchandisemoney)
            {
                total += (decimal)(x);
            }

            return total;
        }

        public int GetTotalPetSalesInMonth(string _year, string _month)
        {
            // Task complete - Huy
            // Querry

            int total = 0;
            var data = from sale in db.Sales
                       join petSale in db.SalesPets
                       on sale.ID equals petSale.SalesID
                       where
                       sale.SaleDate.Month.ToString() == _month
                       && sale.SaleDate.Year.ToString() == _year
                       select new
                       {
                           sale.ID,
                           petSale.PetID
                       };
            total = data.Count();
            return total;
        }

        public int GetTotalProductSalesInMonth(string _year, string _month)
        {
            // Task Complete - Huy
            // Querry

            int total = 0;
            var data = from sale in db.Sales
                       join productSale in db.SalesProducts
                       on sale.ID equals productSale.SalesID
                       where
                       sale.SaleDate.Month.ToString() == _month
                       && sale.SaleDate.Year.ToString() == _year
                       select new
                       {
                           sale_ID = sale.ID,
                           mechandise_ID = productSale.ProductID
                       };
            total = data.Count();
            return total;
        }

        public List<SalesPet> GetSalePeteEachSale(Sale sale)
        {
            List<SalesPet> list = new List<SalesPet>();
            var querry = from s in db.Sales
                          join sp in db.SalesPets
                          on s.ID equals sp.SalesID
                          where s.ID == sale.ID
                          select sp;
            list = querry.ToList();
            return list;
        }

        public List<SalesProduct> GetSaleProductEachSale(Sale sale)
        {
            List<SalesProduct> list = new List<SalesProduct>();
            var querry = from s in db.Sales
                          join sp in db.SalesProducts
                          on s.ID equals sp.SalesID
                          where s.ID == sale.ID
                          select sp;
            list = querry.ToList();
            return list;
        }
    }
}
