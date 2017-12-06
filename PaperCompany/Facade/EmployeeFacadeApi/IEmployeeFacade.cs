using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.AccountingApi;
using Company.Entities.SalesApi;

namespace Company.Facade.EmployeeFacadeApi
{
    public interface IEmployeeFacade
    {
        IAccountant CreateAccountant(string firstName, string lastName);
        ISalesman CreateSalesman(string firstName, string lastName);
        Dictionary<string, string> GetEmployeeIds();
    }
}
