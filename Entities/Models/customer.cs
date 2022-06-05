using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class customer
    {
        public string ID { get; set; }
        public string Phone { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public DateTime DateAdd { get; set; }
        public ICollection<sale> Sales {get; set;}
    }
}
