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
    public class dalSupplier
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.Suppliers.Load();
        }

        public ObservableCollection<Supplier> GetLocal()
        {
            return this.db.Suppliers.Local;
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

        public IQueryable<Supplier> GetAll()
        {
            return this.db.Suppliers;
        }

        public Supplier Find(int id)
        {
            return this.db.Suppliers.Find(id);
        }

        public void Save(Supplier supplier)
        {
            this.db.Suppliers.Add(supplier);
            this.db.SaveChanges();
        }

        public void Modify(Supplier supplier)
        {
            this.db.Entry(supplier).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            Supplier supplier = this.Find(id);
            this.db.Suppliers.Remove(supplier);
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

        public int GetTotalSupplier()
        {
            // Task Complete
            // Querry
            int total = 0;
            total = db.Suppliers.Count();

            return total;
        }

        public List<dynamic> GetOrderPetDetailEachSupplier(Supplier supplier)
        {
            // Task Complete advance - Hieu 
            // Querry
            List<dynamic> list = new List<dynamic>();
            var querry = (from sup in db.Suppliers
                          join ao in db.Orders on sup.ID equals ao.SupplierID
                          join aoi in db.OrderPets on ao.ID equals aoi.OrderID
                          into resultTable
                          where sup.ID == supplier.ID
                          from rsTable in resultTable.DefaultIfEmpty()
                          group rsTable by ao into gr
                          select new
                          {
                              ID = gr.Key.ID,
                              ReceiveDate = gr.Key.ReceiveDate,
                              TotalAnimal = (int?)gr.Where(g => g != null).Select(g => g.PetID).Count() ?? 0,
                              TotalCost = (int?)gr.Where(g => g != null).Select(g => g.Cost).Sum() ?? 0
                          }).OrderByDescending(rs => rs.ID);
            list = querry.ToList<dynamic>();

            return list;
        }

        public List<dynamic> GetOrderProductDetailEachSupplier(Supplier supplier)
        {
            // Task Complete advance - Hieu
            // Querry
            List<dynamic> list = new List<dynamic>();
            var querry = (from sup in db.Suppliers
                          join mo in db.Orders on sup.ID equals mo.SupplierID
                          join moi in db.OrderProducts on mo.ID equals moi.OrderID
                          into resultTable
                          where sup.ID == supplier.ID
                          from rsTable in resultTable.DefaultIfEmpty()
                          group rsTable by mo into gr
                          select new
                          {
                              ID = gr.Key.ID,
                              ReceiveDate = gr.Key.ReceiveDate,
                              TotalQuanity = (int?)gr.Where(g => g != null).Select(g => g.Quantity).Sum() ?? 0,
                              TotalCost = (int?)gr.Where(g => g != null).Select(g => g.Quantity * g.UnitCost).Sum() ?? 0
                          }).OrderByDescending(s => s.ID);
            list = querry.ToList<dynamic>();

            return list;
        }

        public int GetTotalOrderPetEachSupplier(Supplier supplier)
        {
            // Task Complete - Hieu
            // Querry
            int total = 0;

            var querry = from sup in db.Suppliers
                         join ao in db.Orders on sup.ID equals ao.SupplierID
                         join aoi in db.OrderPets on ao.ID equals aoi.OrderID
                         where sup.ID == supplier.ID
                         select aoi.PetID;
            total = querry.Count();

            return total;
        }

        public decimal GetTotalPetCostEachSupplier(Supplier supplier)
        {
            // Task Complete - Hieu
            // Querry
            decimal total = 0;
            var querry = from sup in db.Suppliers
                         join ao in db.Orders on sup.ID equals ao.SupplierID
                         join aoi in db.OrderPets on ao.ID equals aoi.OrderID
                         where sup.ID == supplier.ID
                         select new
                         {
                             Money = ao != null ? aoi.Cost : 0f
                         }.Money;
            total = (decimal)querry.DefaultIfEmpty(0f).Sum();

            return total;
        }

        public int GetTotalOrderProductEachSupplier(Supplier supplier)
        {
            // Task Complete - Hieu
            // Querry
            int total = 0;
            var querry = from sup in db.Suppliers
                         join mo in db.Orders on sup.ID equals mo.SupplierID
                         join moi in db.OrderProducts on mo.ID equals moi.OrderID
                         where sup.ID == supplier.ID
                         select moi.ProductID;
            total = querry.Count();

            return total;
        }

        public decimal GetTotalProductCostEachSupplier(Supplier supplier)
        {
            // Task Complete - Hieu
            // Querry
            decimal total = 0;
            var querry = from sup in db.Suppliers
                         join mo in db.Orders on sup.ID equals mo.SupplierID
                         join moi in db.OrderProducts on mo.ID equals moi.OrderID
                         where sup.ID == supplier.ID
                         select new
                         {
                             Money = mo != null ? moi.UnitCost * moi.Quantity : 0f
                         }.Money;

            total = (decimal)querry.DefaultIfEmpty(0f).Sum();

            return total;
        }
    }
}
