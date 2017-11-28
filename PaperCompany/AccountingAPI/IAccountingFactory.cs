using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entity.AccountingAPI
{
    public interface IAccountingFactory
    {
        IReport CreateReport();
        IAccountant CreateAccountant();
    }
}
