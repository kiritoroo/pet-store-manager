using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Sale
    {
        public Sale()
        {
            SalesPets = new HashSet<SalesPet>();
            SalesProducts = new HashSet<SalesProduct>();
        }

        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime SaleDate { get; set; }
        public float SaleTax { get; set; }
        public string VoucherCode { get; set; }
        public string Status { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual ICollection<SalesPet> SalesPets { get; set; }
        public virtual ICollection<SalesProduct> SalesProducts { get; set; }
    }
}
