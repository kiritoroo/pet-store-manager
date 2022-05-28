using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class merchandiseOrderItem
    {
        public int OrderID { get; set; }
        public string ItemID { get; set; }
        public int Quantity { get; set; }
        public float Cost { get; set; }
    }


}
