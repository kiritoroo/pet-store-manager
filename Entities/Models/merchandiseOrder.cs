using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class merchandiseOrder
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string EmployeeID { get; set; }
        public string SupplierID { get; set; }
        public float ShippingCost { get; set; }
        public employee Employee { get; set; }
        public supplier Supplier { get; set; }
        public ICollection<merchandiseOrderItem> MerchandiseOrderItems { get; set; }
    }
}
