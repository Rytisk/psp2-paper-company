using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Entities.AccountingApi
{
    public interface IAccountingFactory
    {
        IAccountant CreateAccountant(string firstName, string lastName);
    }
}
