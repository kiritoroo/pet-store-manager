using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using Data;
using Entities.Models;

namespace Business.Manager
{
    public class supplierManager
    {
        private DataContext db = new DataContext();

        public IQueryable<supplier> FindAll()
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
            db.Entry(_supplier).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            supplier _supplier = this.Find(id);
            db.suppliers.Remove(_supplier);
            db.SaveChanges();
        }
    }
}
