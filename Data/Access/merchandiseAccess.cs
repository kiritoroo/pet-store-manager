using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using System.Data.Entity;

namespace Data.Access
{
    public class merchandiseAccess : DataContext
    {
        public IQueryable<merchandise> GetAll()
        {
            return this.merchandises;
        }

        public merchandise Find(string id)
        {
            return this.merchandises.Find(id);
        }

        public void Save(merchandise _merchandise)
        {
            this.merchandises.Add(_merchandise);
            this.SaveChanges();
        }

        public void Modify(merchandise _merchandise)
        {
            Entry(_merchandise).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(string id)
        {
            merchandise _merchandise = this.Find(id);
            merchandises.Remove(_merchandise);
            SaveChanges();
        }
    }
}
