using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;

namespace Company.Entities.Accounting.Management
{
    public class ManagementAccountingFactory : IAccountingFactory
    {
        public IAccountant CreateAccountant(string firstName, string lastName)
        {
            return new ManagementAccountant(firstName, lastName);
        }
    }
}
