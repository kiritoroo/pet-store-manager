using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public  class supplier
    {
        public string ID { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<animalOrder> AnimalOrders { get; set; }
        public ICollection<merchandiseOrder> MerchandiseOrders { get; set; }
    }
}
