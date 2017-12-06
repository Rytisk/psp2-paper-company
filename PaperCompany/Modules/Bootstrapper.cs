using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Company.Modules;

namespace Company.Bootstrap
{
    public class Bootstrapper
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<AccountingModule>();
            builder.RegisterModule<SalesModule>();
            builder.RegisterModule<WarehouseModule>();

            builder.RegisterModule<MailModule>();

            builder.RegisterModule<OrderModule>();
            builder.RegisterModule<ProductMaintenanceModule>();
            builder.RegisterModule<SalesmanModule>();
            builder.RegisterModule<AccountantModule>();
            builder.RegisterModule<ReportModule>();

            builder.RegisterModule<AccountingRepositoryModule>();
            builder.RegisterModule<SalesRepositoryModule>();
            builder.RegisterModule<WarehouseRepositoryModule>();

            builder.RegisterModule<EmployeeFacadeModule>();
            builder.RegisterModule<OrderFacadeModule>();
            builder.RegisterModule<ProductFacadeModule>();
            builder.RegisterModule<ReportFacadeModule>();

            builder.RegisterModule<UIModule>();
            
            return builder.Build();
        }
    }
}
