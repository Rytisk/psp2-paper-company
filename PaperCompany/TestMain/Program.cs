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
using Company.UI.Console.Controllers;
using Company.UI.Console;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Features;
using Autofac.Util;
using Autofac;
using Company.Entities.Warehouse.PaperDivision;

namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            //Factories
            builder.RegisterType<SeniorSalesFactory>().As<ISalesFactory>();
            builder.RegisterType<PaperDivisionFactory>().As<IWarehouseFactory>();
            builder.RegisterType<FinanceAccountingFactory>().As<IAccountingFactory>();

            //Services
            builder.RegisterType<NormalSalesmanService>().As<ISalesmanService>();
            builder.RegisterType<NormalAccountantService>().As<IAccountantService>();
            builder.RegisterType<NormalReportService>().As<IReportService>();
            builder.RegisterType<OrderWithCommisionsService>().As<IOrderService>();
            builder.RegisterType<AutoOrderProductMaintenanceService>().As<IProductMaintenanceService>();

            //Repositories
            builder.RegisterInstance(new InMemoryAccountantRepository()).As<IAccountantRepository>();
            builder.RegisterInstance(new InMemorySalesmanRepository()).As<ISalesmanRepository>();
            builder.RegisterInstance(new InMemoryReportRepository()).As<IReportRepository>();
            builder.RegisterInstance(new InMemoryOrderRepository()).As<IOrderRepository>();
            builder.RegisterInstance(new InMemoryDeliveryRepository()).As<IDeliveryRepository>();
            builder.RegisterInstance(new InMemoryProductRepository()).As<IProductRepository>();

            //Integration

            //Facades
            builder.RegisterType<NormalEmployeeFacade>().As<IEmployeeFacade>();
            builder.RegisterType<NormalOrderFacade>().As<IOrderFacade>();
            builder.RegisterType<NormalReportFacade>().As<IReportFacade>();
            builder.RegisterType<NormalProductFacade>().As<IProductFacade>();

            using (var scope = builder.Build().BeginLifetimeScope())
            {
                ConsoleView consoleView = new ConsoleView(new EmployeesController(scope.Resolve<IEmployeeFacade>()), new OrderController(scope.Resolve<IOrderFacade>()), new ProductController(scope.Resolve<IProductFacade>()), new ReportController(scope.Resolve<IReportFacade>()));
                consoleView.StartConsoleView();
            }

                



            
        }
    }
}
