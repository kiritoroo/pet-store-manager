using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class OrderPet
    {
        [Column(Order = 0)]
        public int OrderID { get; set; }
        [Column(Order = 1)]
        public int PetID { get; set; }
        public float Cost { get; set; }
        public virtual Order Order { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
