﻿using System;
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
    public class NormalEmployeeFacade : IEmployeeFacade
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

        public Dictionary<string, string> GetEmployeeIds()
        {
            Dictionary<string, string> employeeIds = new Dictionary<string, string>();

            List<ISalesman> salesmans = _salesmanService.GetAllSalesmans();
            List<IAccountant> accountants = _accountantService.GetAllAccountants();
            
            foreach(var salesman in salesmans)
            {
                employeeIds.Add(salesman.SalesmanId, "Salesman");
            }

            foreach(var accountant in accountants)
            {
                employeeIds.Add(accountant.AccountantId, "Accountant");
            }

            return employeeIds;
        }
    }
}
