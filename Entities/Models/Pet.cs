using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Pet
    {
        public Pet()
        {
            this.SalesPets = new HashSet<SalesPet>();
            this.OrderPets = new HashSet<OrderPet>();
        }

        public int ID { get; set; }
        public string PetCategoryID { get; set; }
        public string Label { get; set; }
        public string Age { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public byte[] Photo { get; set; }
        public virtual PetCategory PetCategory { get; set; }
        public virtual ICollection<SalesPet> SalesPets { get; set; }
        public virtual ICollection<OrderPet> OrderPets { get; set; }
    }
}
