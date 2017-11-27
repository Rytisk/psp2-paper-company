﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    interface ISalesFactory
    {
        IProduct CreateProduct();
        ISalesman CreateSalesman();
        ISale CreateSale();
    }
}