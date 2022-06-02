using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entities.Models;
using Data.Access;

namespace Business.Manager
{
    public class merchandiseManager
    {
        private merchandiseAccess dal = new merchandiseAccess();

        public IQueryable<merchandise> GetAll()
        {
            return this.dal.GetAll();
        }

        public merchandise Find(string id)
        {
            return this.dal.Find(id);
        }

        public void Save(merchandise _merchandise)
        {
            this.dal.Save(_merchandise);
        }

        public void Modify(merchandise _merchandise)
        {
            this.dal.Modify(_merchandise);
        }

        public void Delete(string id)
        {
            this.dal.Delete(id);
        }
    }
}
