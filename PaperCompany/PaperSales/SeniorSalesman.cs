using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Sales.Api;

namespace Company.Entities.Sales.Senior
{
    class SeniorSalesman : ISalesman
    {
        private decimal _earnedMoney;
        private decimal _commisions;
        
        public string SalesmanId { get; private set; }

        public SeniorSalesman()
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
            throw new NotImplementedException();
        }

        public void AddToYearQuota(decimal moneyEarned)
        {
            _earnedMoney += moneyEarned;
        }
    }
}
