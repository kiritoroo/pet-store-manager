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
    public class dalProductCategory
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.ProductCategories.Load();
        }

        public ObservableCollection<ProductCategory> GetLocal()
        {
            return this.db.ProductCategories.Local;
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

        public IQueryable<ProductCategory> GetAll()
        {
            return this.db.ProductCategories;
        }

        public ProductCategory Find(string id)
        {
            return this.db.ProductCategories.Find(id);
        }

        public void Save(ProductCategory productCategory)
        {
            this.db.ProductCategories.Add(productCategory);
            this.db.SaveChanges();
        }

        public void Modify(ProductCategory productCategory)
        {
            this.db.Entry(productCategory).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            ProductCategory productCategory = this.Find(id);
            this.db.ProductCategories.Remove(productCategory);
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

        public IQueryable<Product> GetAllProductEachType(string label)
        {
            var querry = from productType in db.ProductCategories
                         join product in db.Products on productType.ID equals product.ProductCategoryID
                         where productType.Label == label
                         select product;
            return querry;
        }

        public List<dynamic> GetTopSaleProduct()
        {
            // Task Complete advance - Trung
            //Querry

            List<dynamic> list = new List<dynamic>();
            var querry = (from pc in db.ProductCategories
                          join pro in db.Products on pc.ID equals pro.ProductCategoryID into result1
                          from rs1 in result1.DefaultIfEmpty()                          
                          join spro in db.SalesProducts on rs1.ID equals spro.ProductID into result2
                          from rs2 in result2.DefaultIfEmpty()
                          group rs2 by pc into gr
                          select new
                          {
                              ID = gr.Key.ID,
                              Product = gr.Key.Label,
                              Icon = gr.Key.Icon,
                              TotalSales = (int?)gr.Where(g => g != null).Select(g => g.Quantity).Sum() ?? 0,
                              TotalRevenue = (int?)gr.Where(g => g != null).Select(g => g.UnitPrice * g.Quantity).Sum() ?? 0
                          }).OrderByDescending(rs => rs.TotalSales);
            list = querry.ToList<dynamic>();
            return list;
        }
    }
}
