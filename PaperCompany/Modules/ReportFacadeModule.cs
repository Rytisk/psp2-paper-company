using Autofac;
using PaperCompany.Facade.ReportFacadeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Facade.StandardReport;

namespace PaperCompany.Modules
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
