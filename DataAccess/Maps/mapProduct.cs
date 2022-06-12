using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace DataAccess.Maps
{
    public class mapProduct : EntityTypeConfiguration<Product>
    {
        public mapProduct()
        {
            HasKey<int>(pro => pro.ID);
            HasRequired<ProductCategory>(pro => pro.ProductCategory)
                .WithMany(pc => pc.Products)
                .HasForeignKey<string>(pro => pro.ProductCategoryID)
                .WillCascadeOnDelete(false);
        }
    }
}
