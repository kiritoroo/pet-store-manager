using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class animalType
    {
        public string ID { get; set; }
        public string Description { get; set;}
        public ICollection<animal> Animals { get; set; }
    }
}
