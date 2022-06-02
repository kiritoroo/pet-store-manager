using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using System.Data.Entity;

namespace Data.Access
{
    public  class employeeAccess : DataContext
    {
        public IQueryable<employee> GetAll()
        {
            return this.employees;
        }

        public employee Find(string id)
        {
            return this.employees.Find(id);
        }

        public void Save(employee _employee)
        {
            this.employees.Add(_employee);
            this.SaveChanges();
        }

        public void Modify(employee _employee)
        {
            Entry(_employee).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(string id)
        {
            employee _employee = this.Find(id);
            employees.Remove(_employee);
            SaveChanges();
        }
    }
}
