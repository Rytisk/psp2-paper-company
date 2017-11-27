using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Finance
{
    class FinanceAccountingFactory : IAccountingFactory
    {
        public IAccountant CreateAccountant()
        {
            throw new NotImplementedException();
        }

        public IReport CreateReport()
        {
            throw new NotImplementedException();
        }
    }
}
