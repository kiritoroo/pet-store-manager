using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class animal
    {
        public string ID { get; set; }
        public string AnimalTypeID { get; set; }
        public string Label { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public float ListPrice { get; set; }
        public byte[] Photo { get; set; }

        public animalType AnimalType { get; set; }
    }
}
