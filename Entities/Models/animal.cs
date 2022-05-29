using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ICollection<saleAnimal> SaleAnimals { get; set; }
        public ICollection<animalOrderItem> AnimalOrderItems { get; set; }
    }
}
