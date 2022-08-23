using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.ObjectModel;

namespace DataAccess.Access
{
    public class dalEmployee
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.Employees.Load();
        }

        public ObservableCollection<Employee> GetLocal()
        {
            return this.db.Employees.Local;
        }

        public void SaveLocal()
        {
            this.db.SaveChanges();
        }

        public List<DbEntityEntry> GetChangeTracker()
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            return changed;
        }

        public IQueryable<Employee> GetAll()
        {
            return this.db.Employees;
        }

        public Employee Find(int id)
        {
            return this.db.Employees.Find(id);
        }

        public void Save(Employee employee)
        {
            this.db.Employees.Add(employee);
            this.db.SaveChanges();
        }

        public void Modify(Employee employee)
        {
            this.db.Entry(employee).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            Employee employee = this.Find(id);
            this.db.Employees.Remove(employee);
            this.db.SaveChanges();
        }

        public void CancelChanged()
        {
            var changed = this.GetChangeTracker();
            foreach (var obj in changed)
            {
                switch (obj.State)
                {
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        obj.State = EntityState.Unchanged;
                        break;
                }
            }
        }

        public int GetTotalEmployee()
        {
            // Task Complete
            // Querry

            int total = 0;
            total = db.Employees.Count();
            return total;
        }

        public List<Sale> GetSaleDetailEachEmployee(Employee employee)
        {
            // Task Complete
            // Querry

            List<Sale> list = new List<Sale>();
            var querry = from emp in db.Employees
                         join s in db.Sales on emp.ID equals s.EmployeeID
                         where emp.ID == employee.ID
                         select s;
            list = querry.ToList();

            return list;
        }

        public List<Order> GetOrderDetailEachEmployee(Employee employee)
        {
            // Task Complete
            // Querry

            List<Order> list = new List<Order>();
            var querry = from emp in db.Employees
                         join ao in db.Orders on emp.ID equals ao.EmployeeID
                         where emp.ID == employee.ID
                         select ao;
            list = querry.ToList();

            return list;
        }

        public int GetTotalSaleEachEmployee(Employee employee)
        {
            // Task Complete
            // Querry

            int total = 0;
            total = this.GetSaleDetailEachEmployee(employee).Count();
            return total;
        }

        public int GetTotalOrderEachEmployee(Employee employee)
        {
            // Task Complete
            // Querry

            int total = 0;
            total = this.GetOrderDetailEachEmployee(employee).Count();
            return total;
        }

        public Employee FindEmployeeByFullName(string fullName)
        {
            Employee data = new Employee();
            using (var db = new PetStoreDBContext())
            {
                var querry = from emp in db.Employees
                             where emp.LastName + " " + emp.FirstName == fullName
                             select emp;
                data = querry.FirstOrDefault();
            }
            return data;
        }
    }
}
