using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class OrderProduct
    {
        [Column(Order = 0)]
        public int OrderID { get; set; }
        [Column(Order = 1)]
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public float UnitCost { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
