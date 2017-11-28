using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.AccountingAPI;

namespace Company.Entity.ManagementAccounting
{
    class ManagementAccountant : IAccountant
    {
        public int AccountantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IReport WriteReport()
        {
            return new CostsReport();
        }
    }
}
