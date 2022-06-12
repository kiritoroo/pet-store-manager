using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }

        public string ID { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public byte[] Icon { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
