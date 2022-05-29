using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class animalOrderItem
    {
        public int OrderID { get; set; }
        public string AnimalID { get; set; }
        public float Cost { get; set; }
        public animalOrder AnimalOrder { get; set; }
        public animal Animal { get; set; }
    }
}
