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
    public class merchandiseManager
    {
        private DataContext db = new DataContext();

        public IQueryable<merchandise> FindAll()
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
            db.Entry(_merchandise).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            merchandise _merchandise = this.Find(id);
            db.merchandises.Remove(_merchandise);
            db.SaveChanges();
        }
    }
}
