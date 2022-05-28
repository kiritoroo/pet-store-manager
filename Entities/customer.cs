using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class customer
    {
        public string ID { get; set; }
        public string Phone { get; set; }
        public string LastName { get; set; }
        public string FristName { get; set; }
        public string Address { get; set; }

        public ICollection<sale> Sales {get; set;}
    }
}
