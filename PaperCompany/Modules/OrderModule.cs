using Autofac;
using Company.Services.OrderServiceApi;
using Company.Services.OrderWithCommissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Modules
{
    public class OrderModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OrderWithCommisionsService>().As<IOrderService>();
            base.Load(builder);
        }
    }
}
