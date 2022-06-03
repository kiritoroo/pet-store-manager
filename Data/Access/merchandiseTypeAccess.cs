using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class merchandiseTypeAccess
    {
        DataContext db = new DataContext();
        // CRUD
        public IQueryable<merchandiseType> GetAll()
        {
            return this.db.merchandiseTypes;
        }

        public merchandiseType Find(string id)
        {
            return this.db.merchandiseTypes.Find(id);
        }

        public void Add(merchandiseType _merchandiseType)
        {
            this.db.merchandiseTypes.Add(_merchandiseType);
            this.db.SaveChanges();
        }

        public void Modify(merchandiseType _merchandiseType)
        {
            this.db.Entry(_merchandiseType).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            merchandiseType _merchandiseType = this.Find(id);
            this.db.merchandiseTypes.Remove(_merchandiseType);
            this.db.SaveChanges();
        }
    }
}
