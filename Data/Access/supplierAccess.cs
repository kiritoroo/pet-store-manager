using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class supplierAccess : DataContext
    {
        public IQueryable<supplier> GetAll()
        {
            return this.suppliers;
        }

        public supplier Find(string id)
        {
            return this.suppliers.Find(id);
        }

        public void Save(supplier _supplier)
        {
            this.suppliers.Add(_supplier);
            this.SaveChanges();
        }

        public void Modify(supplier _supplier)
        {
            Entry(_supplier).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(string id)
        {
            supplier _supplier = this.Find(id);
            suppliers.Remove(_supplier);
            SaveChanges();
        }
    }
}
