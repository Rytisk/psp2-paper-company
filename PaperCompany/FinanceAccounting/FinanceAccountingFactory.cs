using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.AccountingApi;

namespace PaperCompany.Entities.Finance
{
    public class FinanceAccountingFactory : IAccountingFactory
    {
        public IAccountant CreateAccountant(string firstName, string lastName)
        {
            return new FinanceAccountant(firstName, lastName);
        }
    }
}
