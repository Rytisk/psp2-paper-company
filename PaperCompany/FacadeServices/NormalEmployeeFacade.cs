using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;
using Company.Entities.Sales.Api;
using Company.Facade.Api;
using Company.Services.Api;

namespace Company.Facade.Services
{
    class NormalEmployeeFacade : IEmployeeFacade
    {
        private ISalesmanService _salesmanService;
        private IAccountantService _accountantService;

        public NormalEmployeeFacade(ISalesmanService salesmanService, IAccountantService accountantService)
        {
            _salesmanService = salesmanService;
            _accountantService = accountantService;          
        }

        public IAccountant CreateAccountant(string firstName, string lastName)
        {
            return _accountantService.CreateAccountant(firstName, lastName);
        }

        public ISalesman CreateSalesman(string firstName, string lastName)
        {
            return _salesmanService.CreateSalesman(firstName, lastName);
        }
    }
}
