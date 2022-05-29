using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities.Models;

namespace Data.Maps
{
    public class merchandiseOrderItemMap : EntityTypeConfiguration<merchandiseOrderItem>
    {
        public merchandiseOrderItemMap()
        {
            HasKey(moi => new { moi.OrderID, moi.ItemID });
            HasRequired<merchandiseOrder>(moi => moi.MerchandiseOrder)
                        .WithMany(mo => mo.MerchandiseOrderItems)
                        .HasForeignKey<int>(moi => moi.OrderID)
                        .WillCascadeOnDelete(false);
            HasRequired<merchandise>(moi => moi.Merchandise)
                        .WithMany(m => m.MerchandiseOrderItems)
                        .HasForeignKey<string>(moi => moi.ItemID)
                        .WillCascadeOnDelete(false);
        }
    }
}
