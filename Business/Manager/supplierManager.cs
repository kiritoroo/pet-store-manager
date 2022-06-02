using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
    public class supplierManager
    {
        private supplierAccess dal = new supplierAccess();

        public IQueryable<supplier> GetAll()
        {
            return this.dal.GetAll();
        }

        public supplier Find(string id)
        {
            return this.dal.Find(id);
        }

        public void Save(supplier _supplier)
        {
            this.dal.Save(_supplier);
        }

        public void Modify(supplier _supplier)
        {
            this.dal.Modify(_supplier);
        }

        public void Delete(string id)
        {
            this.dal.Delete(id);
        }
    }
}
