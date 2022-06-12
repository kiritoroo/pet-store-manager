using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee
    {
        public Employee()
        {
            this.Sales = new HashSet<Sale>();
            this.Orders = new HashSet<Order>();
        }

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public byte[] Photo { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
