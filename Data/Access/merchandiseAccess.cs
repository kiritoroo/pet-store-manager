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
    }
}
