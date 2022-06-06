using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class supplierAccess
    {
        DataContext db = new DataContext();
        public IQueryable<supplier> GetAll()
        {
            return this.db.suppliers;
        }

        public supplier Find(string id)
        {
            return this.db.suppliers.Find(id);
        }

        public void Save(supplier _supplier)
        {
            this.db.suppliers.Add(_supplier);
            this.db.SaveChanges();
        }

        public void Modify(supplier _supplier)
        {
            this.db.Entry(_supplier).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            supplier _supplier = this.Find(id);
            this.db.suppliers.Remove(_supplier);
            this.db.SaveChanges();
        }

        public int GetTotalSupplier()
        {
            // Task Complete - Trung
            // Querry

            int total = 0;
            total = db.suppliers.Count();
            return total;
        }

        public List<dynamic> GetOrderAnimalDetailEachSupplier(supplier _supplier)
        {
            // Task Complete advance - Hieu 
            // Querry

            List<dynamic> list = new List<dynamic>();
            var querry = (from sup in db.suppliers
                          join ao in db.animalOrders on sup.ID equals ao.SupplierID
                          join aoi in db.animalOrderItems on ao.ID equals aoi.OrderID
                          into resultTable
                          where sup.ID == _supplier.ID
                          from rsTable in resultTable.DefaultIfEmpty()
                          group rsTable by ao into gr
                          select new
                          {
                              ID = gr.Key.ID,
                              ReceiveDate = gr.Key.ReceiveDate,
                              TotalAnimal = (int?)gr.Where(g => g != null).Select(g => g.AnimalID).Count() ?? 0,
                              TotalCost = (int?)gr.Where(g => g != null).Select(g => g.Cost).Sum() ?? 0
                          }).OrderByDescending(rs => rs.ID);

            list = querry.ToList<dynamic>();
          
            return list;
        }

        public List<dynamic> GetOrderMerchandiseDetailEachSupplier(supplier _supplier)
        {
            // Task Complete advance - Hieu
            // Querry

            List<dynamic> list = new List<dynamic>();           
            var querry = (from sup in db.suppliers
                          join mo in db.merchandiseOrders on sup.ID equals mo.SupplierID
                          join moi in db.merchandiseOrderItems on mo.ID equals moi.OrderID
                          into resultTable
                          where sup.ID == _supplier.ID
                          from rsTable in resultTable.DefaultIfEmpty()
                          group rsTable by mo into gr
                          select new
                          {
                              ID = gr.Key.ID,
                              ReceiveDate = gr.Key.ReceiveDate,
                              TotalQuanity = (int?)gr.Where(g => g != null).Select(g => g.Quantity).Sum() ?? 0,
                              TotalCost = (int?)gr.Where(g => g != null).Select(g => g.Cost).Sum() ?? 0
                          }).OrderByDescending(s => s.ID);
            list = querry.ToList<dynamic>();

            return list;
        }

        public int GetTotalOrderAnimalEachSupplier(supplier _supplier)
        {
            // Task Complete - Hieu
            // Querry
            int total = 0;

            var querry = from sup in db.suppliers
                         join ao in db.animalOrders on sup.ID equals ao.SupplierID
                         join aoi in db.animalOrderItems on ao.ID equals aoi.OrderID
                         where sup.ID == _supplier.ID
                         select aoi.AnimalID;
            total = querry.Count();
            return total;
        }

        public decimal GetTotalCostAnimalEachSupplier(supplier _supplier)
        {
            // Task Complete - Hieu
            // Querry

            decimal total = 0;
            try
            {
                var querry = (from sup in db.suppliers
                              join ao in db.animalOrders on sup.ID equals ao.SupplierID
                              join aoi in db.animalOrderItems on ao.ID equals aoi.OrderID
                              where sup.ID == _supplier.ID
                              select new
                              {
                                  Money = (int?)aoi.Cost ?? 0
                              }).Sum(sa => sa.Money);
                total = (decimal)querry;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                total = 0;
            }
            return total;
        }

        public int GetTotalOrderMerchandiseEachSupplier(supplier _supplier)
        {
            // Task Complete - Hieu
            // Querry
            int total = 0;
            var querry = from sup in db.suppliers
                         join mo in db.merchandiseOrders on sup.ID equals mo.SupplierID
                         join moi in db.merchandiseOrderItems on mo.ID equals moi.OrderID
                         where sup.ID == _supplier.ID
                         select moi.ItemID;
            total = querry.Count();
            return total;
        }

        public decimal GetTotalCostMerchandiseEachSupplier(supplier _supplier)
        {
            // Task Complete - Hieu
            // Querry

            decimal total = 0;
            try
            {
                var querry = (from sup in db.suppliers
                              join mo in db.merchandiseOrders on sup.ID equals mo.SupplierID
                              join moi in db.merchandiseOrderItems on mo.ID equals moi.OrderID
                              where sup.ID == _supplier.ID
                              select new
                              {
                                  Money = moi.Cost
                              }).Sum(sa => sa.Money);
                total = (decimal)querry;
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
                total = 0;
            }
            return total;
        }
    }
}
