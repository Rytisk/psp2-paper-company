using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.AccountingApi;

namespace Company.Entities.Management
{
    public class ManagementAccountingFactory : IAccountingFactory
    {
        public IAccountant CreateAccountant(string firstName, string lastName)
        {
            return new ManagementAccountant(firstName, lastName);
        }
    }
}
