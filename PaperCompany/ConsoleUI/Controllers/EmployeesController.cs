using Company.Entities.Accounting.Api;
using Company.Entities.Sales.Api;
using Company.Facade.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.UI.Console.Controllers
{
    public class EmployeesController
    {
        private IEmployeeFacade _employeeFacade;

        public EmployeesController(IEmployeeFacade employeeFacade)
        {
            _employeeFacade = employeeFacade;
        }

        public void CreateAccountant(string firstName, string lastName)
        {
            IAccountant accountant = _employeeFacade.CreateAccountant(firstName, lastName);
        }

        public void CreateSalesman(string firstName, string lastName)
        {
            ISalesman salesman = _employeeFacade.CreateSalesman(firstName, lastName);
        }

        public string GetAllEmployees()
        {
            Dictionary<string, string> employees = _employeeFacade.GetEmployeeIds();
            string employeesInfo = string.Empty;

            foreach(var employee in employees)
            {
                employeesInfo += string.Format("Id: {0}, Type: {1}", employee.Key, employee.Value);
            }

            return employeesInfo;
        }
    }
}
