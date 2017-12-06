using Autofac;
using Company.Facade.NormalOrder;
using Company.Facade.OrderFacadeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Modules
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
