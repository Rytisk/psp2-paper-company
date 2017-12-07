using Autofac;
using PaperCompany.UI.Api.Views;
using PaperCompany.UI.Console.Controllers;
using PaperCompany.UI.Console.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.UI.Api.Controllers;

namespace PaperCompany.Modules
{
    public class UIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SalesmanController>().As<ISalesmanController>();
            builder.RegisterType<ManagerController>().As<IManagerController>();
            builder.RegisterType<AccountantController>().As<IAccountantController>();
            
            builder.RegisterType<SalesmanView>().As<ISalesmanView>();
            builder.RegisterType<ManagerView>().As<IManagerView>();
            builder.RegisterType<AccountantView>().As<IAccountantView>();
            base.Load(builder);
        }
    }
}
