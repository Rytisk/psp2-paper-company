using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Management
{
    class ManagementAccountant : IAccountant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IReport WriteReport()
        {
            return new CostsReport();
        }
    }
}
