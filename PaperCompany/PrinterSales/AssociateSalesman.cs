﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.SalesApi;

namespace PaperCompany.Entities.Associate
{
    public class AssociateSalesman : ISalesman
    {
        private decimal _earnedMoney;
        private decimal _commisions;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string SalesmanId { get; private set; }

        public AssociateSalesman(string firstName, string lastName)
        {
            SalesmanId = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
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
