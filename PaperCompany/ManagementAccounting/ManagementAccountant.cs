using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;

namespace Company.Entities.Accounting.Management
{
    class ManagementAccountant : IAccountant
    {
        public string AccountantId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ManagementAccountant()
        {
            AccountantId = new Guid().ToString();
        }

        public void LogASale(string productId, int quantity, decimal unitPrice)
        {
            throw new NotImplementedException();
        }

        public IReport WriteReport()
        {
            return new CostsReport();
        }
    }
}
