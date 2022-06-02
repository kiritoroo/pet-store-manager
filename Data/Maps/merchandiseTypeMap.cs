using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class merchandiseTypeMap : EntityTypeConfiguration<merchandiseType>
    {
        public merchandiseTypeMap()
        {
            HasKey<string>(mt => mt.ID);

            Property(p => p.ID)
                .IsRequired()
                .HasMaxLength(10);
            Property(p => p.Description)
                .IsOptional();
        }
    }
}
