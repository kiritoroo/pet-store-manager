using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class employeeMap : EntityTypeConfiguration<employee>
    {
        public employeeMap()
        {
            HasKey<string>(emp => emp.ID);
        }
    }
}
