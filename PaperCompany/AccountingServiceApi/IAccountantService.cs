using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.AccountingApi;

namespace Company.Services.Api
{
    public interface IAccountantService
    {
        IAccountant CreateAccountant(string firstName, string lastName);
        List<IAccountant> GetAllAccountants();
    }
}
