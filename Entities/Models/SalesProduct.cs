using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class SalesProduct
    {
        [Column(Order = 0)]
        public int SalesID { get; set; }
        [Column(Order = 1)]
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Product Product { get; set; }
    }
}
