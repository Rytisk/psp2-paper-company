using Autofac;
using Company.UI.Api.Views;
using Company.UI.Console.Controllers;
using Company.UI.Console.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.UI.Api.Controllers;

namespace Company.Modules
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
