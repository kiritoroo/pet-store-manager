using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderPets = new HashSet<OrderPet>();
            this.OrderProducts = new HashSet<OrderProduct>();
        }

        public int ID { get; set; }
        public int SupplierID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public Nullable<DateTime> ReceiveDate { get; set; }
        public float ShippingCost { get; set; }
        public string Status { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderPet> OrderPets { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
