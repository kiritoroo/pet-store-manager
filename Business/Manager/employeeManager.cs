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
    public class employeeManager
    {
        private DataContext db = new DataContext();

        public IQueryable<employee> FindAll()
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
            db.Entry(_employee).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            employee _employee = this.Find(id);
            db.employees.Remove(_employee);
            db.SaveChanges();
        }

    }
}
