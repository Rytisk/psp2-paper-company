using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    interface IAccountant
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        IReport WriteReport();
    }
}
