using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data;
using Entities.Models;

namespace Business.Manager
{
    public class saleManager
    {
        private DataContext db = new DataContext();

        public IQueryable<sale> GetAll()
        {
            return this.db.sales;
        }

        public List<sale> GetAllList()
        {
            List<sale> list = this.db.sales.ToList();
            return list;
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
            db.Entry(_sale).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            sale _sale = this.Find(id);
            db.sales.Remove(_sale);
            db.SaveChanges();
        }
    }
}
