using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;
using Company.Entities.Sales.Api;

namespace Company.Facade.Api
{
    public interface IEmployeeFacade
    {
        IAccountant CreateAccountant(string firstName, string lastName);
        ISalesman CreateSalesman(string firstName, string lastName);
        Dictionary<string, string> GetEmployeeIds();
    }
}
