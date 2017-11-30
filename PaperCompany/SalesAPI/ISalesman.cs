﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities.Sales.Api
{
    public interface ISalesman
    {
        string SalesmanId { get; }
        decimal GetYearQuota();
        void TakeCommisions(IOrder order);
        void AddToYearQuota(decimal moneyEarned);
        decimal GetCommisions();
    }
}