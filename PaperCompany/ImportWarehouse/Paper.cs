﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Warehouse.Api;

namespace Company.Entities.Warehouse.PaperDivision
{
    public class Paper : IProduct
    {
        private const decimal UNIT_PRICE = 20.5m; 

        public string ProductId { get; private set; }

        public Paper()
        {
            ProductId = Guid.NewGuid().ToString();
        }

        public decimal GetUnitPrice()
        {
            return UNIT_PRICE;
        }

        public string GetName()
        {
            return "Paper";
        }
    }
}
