using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.SalesApi;

namespace Company.Entities.Senior
{
    public class SeniorSalesman : ISalesman
    {
        private decimal _earnedMoney;
        private decimal _commisions;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string SalesmanId { get; private set; }

        public SeniorSalesman(string firstName, string lastName)
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
            _commisions = order.GetTotalPrice() * 0.05m;
        }

        public void AddToYearQuota(decimal moneyEarned)
        {
            _earnedMoney += moneyEarned;
        }
    }
}
