using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using System.Data.Entity;

namespace Data.Access
{
    public class merchandiseAccess
    {
        DataContext db = new DataContext();
        public IQueryable<merchandise> GetAll()
        {
            return this.db.merchandises;
        }

        public merchandise Find(string id)
        {
            return this.db.merchandises.Find(id);
        }

        public void Save(merchandise _merchandise)
        {
            this.db.merchandises.Add(_merchandise);
            this.db.SaveChanges();
        }

        public void Modify(merchandise _merchandise)
        {
            this.db.Entry(_merchandise).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            merchandise _merchandise = this.Find(id);
            this.db.merchandises.Remove(_merchandise);
            this.db.SaveChanges();
        }

        public List<dynamic> GetStatisticAllMerchandise()
        {
            // Task Complete advance - Trung
            //Querry

            List<dynamic> list = new List<dynamic>();
            var querry = (from m in db.merchandises
                         join sm in db.saleMerchandises on m.ID equals sm.MerchandiseID into resultTable
                         from rsTable in resultTable.DefaultIfEmpty()
                         group rsTable by m into gr
                         select new
                         {
                             Product = gr.Key.Label,
                             TotalSales = (int?)gr.Where(g => g != null).Select(g => g.Quantity).Sum() ?? 0,
                             TotalRevenue = (int?)gr.Where(g => g != null).Select(g => g.SalePrice).Sum() ?? 0,
                             QuantityInStock = (int?)gr.Key.QuantityInStock
                         }).OrderByDescending(rs => rs.TotalSales);
            list = querry.ToList<dynamic>();
            return list;
        }
    }
}
