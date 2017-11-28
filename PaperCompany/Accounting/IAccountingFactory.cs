﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public interface IAccountingFactory
    {
        IReport CreateReport();
        IPayment CreatePayment();
    }
}
