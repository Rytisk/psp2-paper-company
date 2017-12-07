using Autofac;
using PaperCompany.Facade.NormalOrder;
using PaperCompany.Facade.OrderFacadeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Modules
{
    public class OrderFacadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NormalOrderFacade>().As<IOrderFacade>();
            base.Load(builder);
        }
    }
}
