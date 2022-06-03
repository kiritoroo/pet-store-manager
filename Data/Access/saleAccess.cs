using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access 
{
    public class saleAccess
    {
        DataContext db = new DataContext();
        public IQueryable<sale> GetAll()
        {
            db.Database.Log = Console.Write;
            return this.db.sales;
        }

        public sale Find(int id)
        {
            db.Database.Log = Console.Write;
            return this.db.sales.Find(id);
        }

        public void Add(sale _sale)
        {
            db.Database.Log = Console.Write;
            this.db.sales.Add(_sale);
            this.db.SaveChanges();
        }

        public void Modify(sale _sale)
        {
            db.Database.Log = Console.Write;
            this.db.Entry(_sale).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Database.Log = Console.Write;
            sale _sale = this.Find(id);
            this.db.sales.Remove(_sale);
            this.db.SaveChanges();
        }

        public int GetTotalBill()
        {
            db.Database.Log = Console.Write;
            int total = 0;
            // Task Uncomplete
            // Querry

            return total;
        }

        public float GetTotalIncome()
        {
            db.Database.Log = Console.Write;
            float total = 0;
            // Task Uncomplete
            // Querry

            return total;
        }

        public float GetTotalIncomeInMonth(string _month)
        {
            db.Database.Log = Console.Write;
            float total = 0;
            // Task Uncomplete
            // Querry

            return total;
        }
    }
}
