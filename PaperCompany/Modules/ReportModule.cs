using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Services.ReportServiceApi;
using PaperCompany.Services.NormalReport;

namespace PaperCompany.Modules
{
    public class ReportModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NormalReportService>().As<IReportService>();
            base.Load(builder);
        }
    }
}
