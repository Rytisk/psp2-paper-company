﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Sales.Api;

namespace Company.Entities.Sales.Associate
{
    class AssociateSalesman : ISalesman
    {
        private decimal _earnedMoney;
        private decimal _commisions;

        public string SalesmanId { get; private set; }

        public AssociateSalesman()
        {
            SalesmanId = new Guid().ToString();
        }

        public decimal GetYearQuota()
        {
            return _earnedMoney;
        }

        public decimal GetCommisions()
        {
            return _commisions;
        }

        public void TakeCommisions(IOrder order)
        {
            _commisions = order.GetTotalPrice() * 0.005m;
        }

        public void AddToYearQuota(decimal moneyEarned)
        {
            _earnedMoney += moneyEarned;
        }
    }
}