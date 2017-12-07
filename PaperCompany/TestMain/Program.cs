using System;

using Autofac;
using PaperCompany.UI.Api.Controllers;
using PaperCompany.Bootstrap;

namespace CompanyMain
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var scope = Bootstrapper.Build().BeginLifetimeScope())
            {
                ISalesmanController salesmanController = scope.Resolve<ISalesmanController>();
                IAccountantController accountantController = scope.Resolve<IAccountantController>();
                IManagerController managerController = scope.Resolve<IManagerController>();

                bool show = true;
                while(show)
                {
                    Console.WriteLine("1. Manager\n2. Accountant\n3. Salesman\n");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            managerController.LoadView();
                            break;
                        case "2":
                            accountantController.LoadView();
                            break;
                        case "3":
                            salesmanController.LoadView();
                            break;
                        case "exit":
                            show = false;
                            break;
                        default:
                            Console.WriteLine("Wrong option");
                            break;
                    }
                }
            }
        }
    }
}
