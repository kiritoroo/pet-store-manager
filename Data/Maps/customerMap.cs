using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class customerMap : EntityTypeConfiguration<customer>
    {
        public customerMap()
        {
            HasKey<string>(c => c.ID);
        }
    }
}
