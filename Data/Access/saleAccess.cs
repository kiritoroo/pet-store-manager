using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access 
{
    public class saleAccess : DataContext
    {
        public IQueryable<sale> GetAll()
        {
            return this.sales;
        }

        public sale Find(int id)
        {
            return this.sales.Find(id);
        }

        public void Add(sale _sale)
        {
            this.sales.Add(_sale);
            this.SaveChanges();
        }

        public void Modify(sale _sale)
        {
            Entry(_sale).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int id)
        {
            sale _sale = this.Find(id);
            sales.Remove(_sale);
            SaveChanges();
        }
    }
}
