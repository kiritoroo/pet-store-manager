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
    }
}
