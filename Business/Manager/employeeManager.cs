using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
    public class employeeManager
    {
        private employeeAccess dal = new employeeAccess();

        public IQueryable<employee> GetAll()
        {
            return this.dal.GetAll();
        }

        public employee Find(string id)
        {
            return this.dal.Find(id);
        }

        public void Save(employee _employee)
        {
            this.dal.Save(_employee);
        }

        public void Modify(employee _employee)
        {
            this.dal.Modify(_employee);
        }

        public void Delete(string id)
        {
            this.dal.Delete(id);
        }
    }
}
