using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.AccountingAPI;

namespace Company.Entity.ManagementAccounting
{
    class ManagementAccountingFactory : IAccountingFactory
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
