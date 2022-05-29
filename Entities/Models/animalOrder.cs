using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class animalOrder
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string EmployeeID { get; set; }
        public string SupplierID { get; set; }
        public float ShippingCost { get; set; }

    }
}
