using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class merchandiseTypeAccess : DataContext
    {
        // CRUD
        public IQueryable<merchandiseType> GetAll()
        {
            return this.merchandiseTypes;
        }

        public merchandiseType Find(string id)
        {
            return this.merchandiseTypes.Find(id);
        }

        public void Add(merchandiseType _merchandiseType)
        {
            this.merchandiseTypes.Add(_merchandiseType);
            this.SaveChanges();
        }

        public void Modify(merchandiseType _merchandiseType)
        {
            Entry(_merchandiseType).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(string id)
        {
            merchandiseType _merchandiseType = this.Find(id);
            merchandiseTypes.Remove(_merchandiseType);
            SaveChanges();
        }
    }
}
