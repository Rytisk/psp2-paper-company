using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Finance
{
    class FinanceAccountant : IAccountant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IReport WriteReport()
        {
            return new FinancialStatement();
        }
    }
}
