using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;

namespace Company.Entities.Accounting.Finance
{
    public class FinanceAccountant : IAccountant
    { 
        public string AccountantId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public FinanceAccountant()
        {
            AccountantId = new Guid().ToString();
        }

        public void LogASale(string productId, int quantity, decimal unitPrice)
        {
            throw new NotImplementedException();
        }

        public IReport WriteReport()
        {
            return new FinancialStatement();
        }
    }
}
