using Company.UI.Api.Views;
using Company.UI.Api.Controllers;

namespace Company.UI.Console.Views
{
    public class ManagerView : IManagerView
    {
        private IManagerController _controller;

        public void AddController(IManagerController controller)
        {
            _controller = controller;
        }

        public void ShowMenu()
        {
            bool show = true;

            while (show)
            {
                System.Console.WriteLine("1. Create accountant\n2. Create salesman\n3. Get all employees\n4. Deliver products to warehouse\n5. Get all products\n");
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
                        System.Console.WriteLine(_controller.GetAllEmployees());
                        break;
                    case "4":
                        DeliverProducts();
                        break;
                    case "5":
                        System.Console.WriteLine(_controller.GetAllProducts());
                        break;
                    case "exit":
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
            _controller.CreateAccountant(accName, accLast);
        }

        private void CreateSalesman()
        {
            System.Console.WriteLine("Enter first and last names: \n");
            string salName = System.Console.ReadLine();
            string salLast = System.Console.ReadLine();
            _controller.CreateSalesman(salName, salLast);
        }

        private void DeliverProducts()
        {
            System.Console.WriteLine("Enter product quantity: ");
            int quantity = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter supplier address: ");
            string address = System.Console.ReadLine();
            _controller.DeliverProductsToWarehouse(quantity, address);
        }
    }
}
