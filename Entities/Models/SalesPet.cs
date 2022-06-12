using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class SalesPet
    {
        [Column(Order = 0)]
        public int SalesID { get; set; }
        [Column(Order = 1)]
        public int PetID { get; set; }
        public float Price { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
