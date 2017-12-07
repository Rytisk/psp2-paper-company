using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.AccountingApi;

namespace PaperCompany.Services.AccountantServiceApi
{
    public interface IAccountantService
    {
        IAccountant CreateAccountant(string firstName, string lastName);
        List<IAccountant> GetAllAccountants();
    }
}
