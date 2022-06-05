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
            // Task Complete
            // Querry

            int total = 0;
            total = db.employees.Count();
            return total;
        }

        public List<sale> GetSaleDetailEachEmployee(employee _employee)
        {
            // Task Uncomplete
            // Querry

            List<sale> list = new List<sale>();

            return list;
        }

        public List<animalOrder> GetOrderAnimalDetailEachEmployee(employee _employee)
        {
            // Task Uncomplete
            // Querry

            List<animalOrder> list = new List<animalOrder>();

            return list;
        }

        public List<merchandiseOrder> GetOrderMerchandiseDetailEachEmployee(employee _employee)
        {
            // Task Uncomplete
            // Querry

            List<merchandiseOrder> list = new List<merchandiseOrder>();

            return list;
        }

        public int GetTotalSaleEachEmployee(employee _employee)
        {
            // Task Uncomplete
            // Querry

            int total = 0;

            return total;
        }

        public int GetTotalOrderAnimalEachEmployee(employee _employee)
        {
            // Task Uncomplete
            // Querry

            int total = 0;

            return total;
        }

        public int GetTotalOrderMerchandiseEachEmployee(employee _employee)
        {
            // Task Uncomplete
            // Querry

            int total = 0;

            return total;
        }
    }
}
