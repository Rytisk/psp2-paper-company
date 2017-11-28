using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entity.AccountingAPI
{
    public interface IAccountant
    {
        int AccountantId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        IReport WriteReport();
    }
}
