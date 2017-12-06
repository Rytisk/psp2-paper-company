using Autofac;
using Company.Facade.ReportFacadeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Facade.StandardReport;

namespace Company.Modules
{
    public class ReportFacadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StandardReportFacade>().As<IReportFacade>();
            base.Load(builder);
        }
    }
}
