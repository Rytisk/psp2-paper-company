using PaperCompany.Entities.AccountingApi;
using PaperCompany.Entities.SalesApi;
using PaperCompany.Facade.EmployeeFacadeApi;
using PaperCompany.Facade.ProductFacadeApi;
using PaperCompany.UI.Api.Views;
using System.Collections.Generic;
using PaperCompany.UI.Api.Controllers;

namespace PaperCompany.UI.Console.Controllers
{
    public class ManagerController : IManagerController
    {
        private IProductFacade _productFacade;
        private IEmployeeFacade _employeeFacade;
        private IManagerView _view;

        public ManagerController(IProductFacade productFacade, IEmployeeFacade employeeFacade, IManagerView view)
        {
            _productFacade = productFacade;
            _employeeFacade = employeeFacade;
            _view = view;
            _view.AddController(this);
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

            foreach (var employee in employees)
            {
                employeesInfo += string.Format("Id: {0}, Type: {1}", employee.Key, employee.Value);
            }

            return employeesInfo;
        }

        public void DeliverProductsToWarehouse(int quantity, string source)
        {
            _productFacade.DeliverProductsToWarehouse(quantity, source);
        }

        public string GetProduct(string productId)
        {
            var product = _productFacade.GetProduct(productId);
            return string.Format("Name: {0}, Id: {1}, Price: {2}", product.GetName(), product.ProductId, product.GetUnitPrice());
        }

        public string GetAllProducts()
        {
            string productsInfo = string.Empty;
            var products = _productFacade.GetAllProducts();
            foreach (var product in products)
            {
                productsInfo += string.Format("Name: {0}, Id: {1}, Price: {2}", product.GetName(), product.ProductId, product.GetUnitPrice());
            }
            return productsInfo;
        }

        public void LoadView()
        {
            _view.ShowMenu();
        }
    }
}
