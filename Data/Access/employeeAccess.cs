using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using System.Data.Entity;

namespace Data.Access
{
    public  class employeeAccess
    {
        DataContext db = new DataContext();
        public IQueryable<employee> GetAll()
        {
            return this.db.employees;
        }

        public employee Find(string id)
        {
            return this.db.employees.Find(id);
        }

        public void Save(employee _employee)
        {
            this.db.employees.Add(_employee);
            this.db.SaveChanges();
        }

        public void Modify(employee _employee)
        {
            this.db.Entry(_employee).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            employee _employee = this.Find(id);
            this.db.employees.Remove(_employee);
            this.db.SaveChanges();
        }
    }
}
