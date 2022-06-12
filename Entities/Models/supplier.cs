using System.Collections.Generic;

namespace Entities.Models
{
    public class Supplier
    {
        public Supplier()
        {
            this.Orders = new HashSet<Order>();
        }

        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
