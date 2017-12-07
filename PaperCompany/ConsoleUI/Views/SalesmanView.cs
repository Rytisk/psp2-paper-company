using PaperCompany.UI.Api.Views;
using System.Collections.Generic;
using PaperCompany.UI.Api.Controllers;

namespace PaperCompany.UI.Console.Views
{
    public class SalesmanView : ISalesmanView
    {
        private ISalesmanController _controller;

        public void AddController(ISalesmanController controller)
        {
            _controller = controller;
        }

        public void ShowMenu()
        {
            bool show = true;
            while (show)
            {
                System.Console.WriteLine("1. Create order\n");
                string choice = System.Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateOrder();
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

        public void ShowOrderInfo(string orderId, int quantity, decimal totalPrice)
        {
            var info = string.Format("OrderId: {0}, Product quantity: {1}, Total price: {2}", orderId, quantity, totalPrice);
            System.Console.WriteLine(info);
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
            _controller.CreateOrder(productIds, price, salesmanid);
        }
    }
}
