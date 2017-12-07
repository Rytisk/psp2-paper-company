using Autofac;
using PaperCompany.Services.NormalSalesman;
using PaperCompany.Services.SalesmanServiceApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Modules
{
    public class SalesmanModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NormalSalesmanService>().As<ISalesmanService>();
            base.Load(builder);
        }
    }
}
