﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Paper
{
    class Paper : IProduct
    {
        public string Name { get; set; }
        public string Supplier { get; set; }
        public decimal Price { get; set; }
        public int ID { get; set; }
    }
}