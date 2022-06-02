using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
    public class merchandiseTypeManager
    {
        private merchandiseTypeAccess dal = new merchandiseTypeAccess();

        public IQueryable<merchandiseType> GetAll()
        {
            return this.dal.GetAll();
        }

        public merchandiseType Find(string id)
        {
            return this.dal.Find(id);
        }

        public void Add(merchandiseType _merchandiseType)
        {
            this.dal.Add(_merchandiseType);
        }

        public void Modify(merchandiseType _merchandiseType)
        {
            this.dal.Modify(_merchandiseType);
        }

        public void Delete(string id)
        {
            this.dal.Delete(id);
        }
    }
}
