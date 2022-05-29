using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class merchandiseOrderItem
    {
        public int OrderID { get; set; }
        public string ItemID { get; set; }
        public int Quantity { get; set; }
        public float Cost { get; set; }
        public merchandiseOrder MerchandiseOrder { get; set; }
        public merchandise Merchandise { get; set; }
    }


}
