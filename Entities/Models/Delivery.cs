using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Delivery
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public DateTime SentDate { get; set; }
        public Nullable<DateTime> ReceiveDate { get; set; }
        public string ShippingCode { get; set; }
        public string ShippingUnit { get; set; }
        public string Status { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
