using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Product
    {
        public Product()
        {
            this.SalesProducts = new HashSet<SalesProduct>();
            this.OrderProducts = new HashSet<OrderProduct>();
        }

        [Column(Order = 0)]
        public int ID { get; set; }
        public string ProductCategoryID { get; set; }
        public string Label { get; set; }
        public string QuantityPerUnit { get; set; }
        public float UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public byte[] Photo { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<SalesProduct> SalesProducts { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
