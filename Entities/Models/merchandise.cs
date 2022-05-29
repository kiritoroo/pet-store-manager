﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class merchandise
    {
        public string ID { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public int QuantityInStock { get; set; }
        public float ListPrice { get; set; }
        public ICollection<saleItem> SaleItems { get; set; }
        public ICollection<merchandiseOrderItem> MerchandiseOrderItems { get; set; }

    }
}