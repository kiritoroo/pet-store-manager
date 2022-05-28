using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities
{
    public class animalType
    {
/*        public animalType(string iD, string description, ICollection<animal> animals)
        {
            ID = iD;
            Description = description;
            Animals = animals;
        }*/

        public string ID { get; set; }
        public string Description { get; set;}
        public ICollection<animal> Animals { get; set; }

    }
}
