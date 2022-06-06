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

        public int GetTotalEmployee()
        {
            // Task Complete - Trung
            // Querry

            int total = 0;
            total = db.employees.Count();
            return total;
        }

        public List<sale> GetSaleDetailEachEmployee(employee _employee)
        {
            // Task Complete - Trung
            // Querry

            List<sale> list = new List<sale>();
            var querry = from emp in db.employees
                         join s in db.sales
                         on emp.ID equals s.EmployeeID
                         where emp.ID == _employee.ID
                         select s;
            list = querry.ToList();

            return list;
        }

        public List<animalOrder> GetOrderAnimalDetailEachEmployee(employee _employee)
        {
            // Task Complete - Trung
            // Querry
            
            List<animalOrder> list = new List<animalOrder>();
            var querry = from emp in db.employees
                         join ao in db.animalOrders
                         on emp.ID equals ao.EmployeeID
                         where emp.ID == _employee.ID
                         select ao;
            list = querry.ToList();

            return list;
        }

        public List<merchandiseOrder> GetOrderMerchandiseDetailEachEmployee(employee _employee)
        {
            // Task Complete - Trung
            // Querry

            List<merchandiseOrder> list = new List<merchandiseOrder>();
            var querry = from emp in db.employees
                         join mo in db.merchandiseOrders
                         on emp.ID equals mo.EmployeeID
                         where emp.ID == _employee.ID
                         select mo;
            list = querry.ToList();

            return list;
        }

        public int GetTotalSaleEachEmployee(employee _employee)
        {
            // Task Complete - Trung
            // Querry

            int total = 0;
            total = this.GetSaleDetailEachEmployee(_employee).Count();
            return total;
        }

        public int GetTotalOrderAnimalEachEmployee(employee _employee)
        {
            // Task Complete - Trung
            // Querry

            int total = 0;
            total = this.GetOrderAnimalDetailEachEmployee(_employee).Count();
            return total;
        }

        public int GetTotalOrderMerchandiseEachEmployee(employee _employee)
        {
            // Task Complete - Trung
            // Querry

            int total = 0;
            total = this.GetOrderMerchandiseDetailEachEmployee(_employee).Count();
            return total;
        }
    }
}
