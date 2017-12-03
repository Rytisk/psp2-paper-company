using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.UI.Console.Controllers;

namespace Company.UI.Console
{
    public class ConsoleView
    {
        private EmployeesController _employeesController;
        private OrderController _orderController;
        private ProductController _productController;
        private ReportController _reportController;

        public ConsoleView(EmployeesController employeesController, OrderController orderController, ProductController productController, ReportController reportController)
        {
            _employeesController = employeesController;
            _orderController = orderController;
            _productController = productController;
            _reportController = reportController;
        }

        public void StartConsoleView()
        {
            bool show = true;

            while (show)
            {
                System.Console.WriteLine("1. Create accountant\n2. Create salesman\n3. Get all employees\n4. Create order\n5. Deliver products to warehouse\n6. Get all products\n7. Write report\n");
                string choice = System.Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateAccountant();
                        break;
                    case "2":
                        CreateSalesman();
                        break;
                    case "3":
                        System.Console.WriteLine(_employeesController.GetAllEmployees());
                        break;
                    case "4":
                        CreateOrder();
                        break;
                    case "5":
                        DeliverProducts();
                        break;
                    case "6":
                        System.Console.WriteLine(_productController.GetAllProducts());
                        break;
                    case "7":
                        WriteReport();
                        break;
                    case "8":
                        show = false;
                        break;
                    default:
                        System.Console.WriteLine("No such option");
                        break;
                }
            }
        }
        private void CreateAccountant()
        {
            System.Console.WriteLine("Enter first and last names: \n");
            string accName = System.Console.ReadLine();
            string accLast = System.Console.ReadLine();
            var accId = _employeesController.CreateAccountant(accName, accLast);
            System.Console.WriteLine("Accountant created. Id: " + accId);
        }

        private void CreateSalesman()
        {
            System.Console.WriteLine("Enter first and last names: \n");
            string salName = System.Console.ReadLine();
            string salLast = System.Console.ReadLine();
            var salid = _employeesController.CreateSalesman(salName, salLast);
            System.Console.WriteLine("Salesman created. Id: " + salid);
        }

        private void CreateOrder()
        {
            System.Console.WriteLine("Enter product quantity: ");
            int productQt = int.Parse(System.Console.ReadLine());
            List<string> productIds = new List<string>();
            for (int i = 0; i < productQt; i++)
            {
                System.Console.WriteLine("Enter product id: ");
                productIds.Add(System.Console.ReadLine());
            }
            System.Console.WriteLine("Enter unit price: ");
            decimal price = decimal.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter salesman id: ");
            string salesmanid = System.Console.ReadLine();
            var info = _orderController.CreateOrder(productIds, price, salesmanid);
            System.Console.WriteLine(info);
        }

        private void DeliverProducts()
        {
            System.Console.WriteLine("Enter product quantity: ");
            int quantity = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter supplier address: ");
            string address = System.Console.ReadLine();
            _productController.DeliverProductsToWarehouse(quantity, address);
        }

        private void WriteReport()
        {
            System.Console.WriteLine("Enter accountant id: ");
            string accountantId = System.Console.ReadLine();
            System.Console.WriteLine("Enter report description: ");
            string description = System.Console.ReadLine();
            System.Console.WriteLine("Enter order id: ");
            string orderId = System.Console.ReadLine();
            var orderInfo = _reportController.WriteReport(accountantId, description, orderId);
            System.Console.WriteLine(orderInfo);
        }
    }
}