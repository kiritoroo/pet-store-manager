using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Voucher
    {
        public Voucher()
        {
            this.Sales = new HashSet<Sale>();
        }

        public string Code { get; set; }
        public int Percent { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
