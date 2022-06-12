using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapProductCategory : EntityTypeConfiguration<ProductCategory>
    {
        public mapProductCategory()
        {
            HasKey<string>(pc => pc.ID);
        }
    }
}
