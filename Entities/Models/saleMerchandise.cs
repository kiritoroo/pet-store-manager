using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class saleMerchandise
    {
        public int SaleID { get; set; }
        public string ItemID { get; set; }
        public int Quantity { get; set; }
        public float SalePrice { get; set; }
        public sale Sale { get; set; }
        public merchandise Merchandise { get; set; }
    }
}
