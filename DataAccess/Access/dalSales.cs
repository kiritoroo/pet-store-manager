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

        public void Load()
        {
            using (var db = new PetStoreDBContext())
            {
                db.Sales.Load();
            }
        }

        public ObservableCollection<Sale> GetLocal()
        {
            using (var db = new PetStoreDBContext())
            {
                return db.Sales.Local;
            }
        }

        public void SaveLocal()
        {
            using (var db = new PetStoreDBContext())
            {
                db.SaveChanges();
            }
        }

        public List<DbEntityEntry> GetChangeTracker()
        {
            using (var db = new PetStoreDBContext())
            {
                var changed = db.ChangeTracker.Entries().Where(x => x.State != System.Data.Entity.EntityState.Unchanged).ToList();
                return changed;
            }
        }

        public IQueryable<Sale> GetAll()
        {
            using (var db = new PetStoreDBContext())
            {
                return db.Sales;
            }
        }

        public Sale Find(int id)
        {
            using (var db = new PetStoreDBContext())
            {
                return db.Sales.Find(id);
            }
        }

        public void Save(Sale sale)
        {
            using (var db = new PetStoreDBContext())
            {
                db.Sales.Add(sale);
                db.SaveChanges();
            }
        }

        public void Modify(Sale sale)
        {
            using (var db = new PetStoreDBContext())
            {
                db.Entry(sale).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new PetStoreDBContext())
            {
                Sale sale = this.Find(id);
                db.Sales.Remove(sale);
                db.SaveChanges();
            }
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
            using (var db = new PetStoreDBContext())
            {
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
            }
            return total;
        }

        public decimal GetTotalIncomeInMonth(string _year, string _month)
        {
            // Task Complete - Hieu
            // Querry
            decimal total = 0;
            using (var db = new PetStoreDBContext())
            {

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
            }
            return total;
        }


        public int GetTotalPetSalesInMonth(string _year, string _month)
        {
            // Task complete - Huy
            // Querry
            int total = 0;
            using (var db = new PetStoreDBContext())
            {
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
            }
            return total;
        }

        public int GetTotalProductSalesInMonth(string _year, string _month)
        {
            // Task Complete - Huy
            // Querry
            int total = 0;
            using (var db = new PetStoreDBContext())
            {
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
            }
            return total;
        }

        public List<SalesPet> GetSalePeteEachSale(Sale sale)
        {
            List<SalesPet> list = new List<SalesPet>();
            using (var db = new PetStoreDBContext())
            {
                var querry = from s in db.Sales
                             join sp in db.SalesPets
                             on s.ID equals sp.SalesID
                             where s.ID == sale.ID
                             select sp;
                list = querry.ToList();
            }
            return list;
        }

        public List<SalesProduct> GetSaleProductEachSale(Sale sale)
        {
            List<SalesProduct> list = new List<SalesProduct>();
            using (var db = new PetStoreDBContext())
            {
                var querry = from s in db.Sales
                             join sp in db.SalesProducts
                             on s.ID equals sp.SalesID
                             where s.ID == sale.ID
                             select sp;
                list = querry.ToList();
            }
            return list;
        }

        public (string ContactName, string Phone, string Address) GetInfoCustomerEachSale(Sale sale)
        {
            (string ContactName, string Phone, string Address) data;
            using (var db = new PetStoreDBContext())
            {
                var querry = from s in db.Sales
                             join c in db.Customers
                             on s.CustomerID equals c.ID
                             where s.ID == sale.ID
                             select new
                             { 
                                 ContactName = c.ContactName,
                                 Phone = c.Phone,
                                 Address = c.Address
                             };
                data.ContactName = querry.Select(q => q.ContactName).FirstOrDefault();
                data.Phone = querry.Select(q => q.Phone).FirstOrDefault();
                data.Address = querry.Select(q => q.Address).FirstOrDefault();
            }
            return data;
        }

        public (string FullName, string Phone) GetInfoEmployeeEachSale(Sale sale)
        {
            (string FullName, string Phone) data;
            using (var db = new PetStoreDBContext())
            {
                var querry = from s in db.Sales
                             join c in db.Employees
                             on s.EmployeeID equals c.ID
                             where s.ID == sale.ID
                             select new
                             {
                                 FullName = c.LastName + " " + c.FirstName,
                                 Phone = c.Phone,
                             };
                data.FullName = querry.Select(q => q.FullName).FirstOrDefault();
                data.Phone = querry.Select(q => q.Phone).FirstOrDefault();
            }
            return data;
        }

        public int GetTotalPetEachSale(Sale sale)
        {
            int data = 0;
            using (var db = new PetStoreDBContext())
            {
                var querry = (from s in db.Sales
                              join sp in db.SalesPets
                              on s.ID equals sp.SalesID
                              where s.ID == sale.ID
                              group sp by sp into gr
                              select new
                              {
                                  SalePet = gr.Key
                              });
                data = querry.Count();
            }
            return data;
        }

        public decimal GetTotalMoneyPetEachSale(Sale sale)
        {
            decimal data = 0;
            using (var db = new PetStoreDBContext())
            {
                var querry = (from s in db.Sales
                              join sp in db.SalesPets
                              on s.ID equals sp.SalesID
                              where s.ID == sale.ID
                              group sp by sp into gr
                              select new
                              {
                                  SalePrice = (int?)gr.Key.Price
                              }).Sum(sa => sa.SalePrice) ?? 0;
                data = (decimal)querry;
            }
            return data;
        }

        public int GetTotalProductEachSale(Sale sale)
        {
            int data = 0;
            using (var db = new PetStoreDBContext())
            {
                var querry = (from s in db.Sales
                              join sp in db.SalesProducts
                              on s.ID equals sp.SalesID
                              where s.ID == sale.ID
                              group sp by sp into gr
                              select new
                              {
                                  SaleProduct = gr.Key.Quantity
                              });
                data = querry.Sum(q => q.SaleProduct);
            }
            return data;
        }

        public decimal GetTotalMoneyProductEachSale(Sale sale)
        {
            decimal data = 0;
            using (var db = new PetStoreDBContext())
            {
                var querry = (from s in db.Sales
                              join sp in db.SalesProducts
                              on s.ID equals sp.SalesID
                              where s.ID == sale.ID
                              group sp by sp into gr
                              select new
                              {
                                  Quanity = (int?)gr.Key.Quantity,
                                  SalePrice = (int?)gr.Key.UnitPrice
                              }).Sum(sa => sa.SalePrice * sa.Quanity) ?? 0;
                data = (decimal)querry;
            }
            return data;
        }

        public Voucher GetInfoVoucherEachSale(Sale sale)
        {
            Voucher data = null;
            using (var db = new PetStoreDBContext())
            {
                var querry = from s in db.Sales
                             join v in db.Vouchers
                             on s.VoucherCode equals v.Code
                             where s.ID == sale.ID
                             select v;
                data = querry.FirstOrDefault();
            }
            return data;
        }

        public (bool success, String message, Pet petOut, Product proOut) CreateBill(Sale sale)
        {
            using (var context = new PetStoreDBContext())
            {
                using (DbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    (bool success, String message, Pet petOut, Product proOut) rs = (true, "Mess", null, null);
                    try
                    {
                        context.Sales.Add(sale);
                        context.SaveChanges();

                        var querry1 = from s in sale.SalesPets
                                      select s;
                        foreach (SalesPet sp in querry1)
                        {
                            Pet petChoose = (from p in context.Pets
                                      where p.ID == sp.PetID
                                      select p).FirstOrDefault();
                            if (petChoose.Status != "Stocking")
                            {
                                rs.petOut = petChoose;
                                throw new Exception();
                            }
                            else
                            {
                                petChoose.Status = "Out of Stock";
                                context.Entry(petChoose).State = EntityState.Modified;
                                context.SaveChanges();
                            }
                        }
                        
                        var querry2 = from p in sale.SalesProducts select p;
                        foreach(SalesProduct spro in querry2)
                        {
                            Product pro = (from pr in context.Products
                                           where pr.ID == spro.ProductID
                                           select pr).FirstOrDefault();
                            if(pro.UnitsInStock < 1 || spro.Quantity > pro.UnitsInStock)
                            {
                                rs.proOut = pro;
                                throw new Exception();
                            }
                            else
                            {
                                pro.UnitsInStock = pro.UnitsInStock - spro.Quantity;
                                context.Entry(pro).State = EntityState.Modified;
                                context.SaveChanges();
                            }
                        }    
                        transaction.Commit();
                        rs.success = true;
                        rs.message = "Success";
                        return rs;
                    }

                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine(ex.Message);
                        rs.success = false;
                        rs.message = "False";
                        return rs;
                    }
                    finally
                    {
                        transaction.Dispose();
                    }
                }
            }
        }
    }
}
