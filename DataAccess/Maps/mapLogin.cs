using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapLogin : EntityTypeConfiguration<Login>
    {
        public mapLogin()
        {
            HasKey<Guid>(lg => lg.ID);
        }
    }
}
