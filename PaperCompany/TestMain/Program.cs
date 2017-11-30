using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Services.Api;
using Company.Services.Accounting;
using Company.Entities.Accounting.Finance;
using Company.Repository.Accounting;
using Company.Entities.Accounting.Api;
using Company.Facade.Api;
using Company.Facade.Services;
using Company.Services.Sales;
using Company.Entities.Sales.Api;
using Company.Entities.Sales.Senior;
using Company.Repository.Sales;
using Company.Services.Warehouse;
using Company.Entities.Warehouse.Api;
using Company.Entities.Warehouse.PrinterDivision;
using Company.Repository.Warehouse;
using Company.Repository.Api;

namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            ISalesmanRepository salesmanRepository = new InMemorySalesmanRepository();
            ISalesman salesman = new SeniorSalesFactory().CreateSalesman("Jonas", "Jonaitis");
            salesmanRepository.Add(salesman);
            IProductRepository productRepository = new InMemoryProductRepository();
            IProduct product = new PrinterDivisionFactory().CreateProduct();
            IProduct product2 = new PrinterDivisionFactory().CreateProduct();
            productRepository.Add(product);
            productRepository.Add(product2);

            IOrderFacade orderFacade = new NormalOrderFacade(new OrderWithCommisionsService(new SeniorSalesFactory(), salesmanRepository, new InMemoryOrderRepository()), new AutoOrderProductMaintenanceService(new PrinterDivisionFactory(), productRepository, new InMemoryDeliveryRepository()));

            IOrder order = orderFacade.CreateOrder(new List<string>() { product.ProductId }, 20.5m, salesman.SalesmanId);
            Console.WriteLine(order.OrderId);
            Console.WriteLine(order.GetTotalPrice());
            Console.ReadLine();
        }
    }
}
