using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    interface ISalesman
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        decimal SalesQuota { get; set; }

        void MakeSale(ISale sale);
    }
}
