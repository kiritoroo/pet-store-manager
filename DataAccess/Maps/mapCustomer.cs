using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapCustomer : EntityTypeConfiguration<Customer>
    {
        public mapCustomer()
        {
            HasKey<int>(cus => cus.ID);
        }
    }
}
