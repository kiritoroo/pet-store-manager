using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PetCategory
    {
        public PetCategory()
        {
            Pets = new HashSet<Pet>();
        }

        public string ID { get; set; }
        public string Label { get; set; }
        public byte[] Icon { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
    }
}
    