using Autofac;
using Company.Services.AutoOrderProductMaintenance;
using Company.Services.ProductMaintenanceServiceApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Modules
{
    public class ProductMaintenanceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AutoOrderProductMaintenanceService>().As<IProductMaintenanceService>();
            base.Load(builder);
        }
    }
}
