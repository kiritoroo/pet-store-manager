﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class merchandiseType
    {
        public string ID { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public byte[] Icon { get; set; }
        public ICollection<merchandise> Merchandises { get; set; }
    }
}