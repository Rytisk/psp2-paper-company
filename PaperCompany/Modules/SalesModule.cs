using Autofac;
using PaperCompany.Entities.SalesApi;
using PaperCompany.Entities.Senior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Modules
{
    public class SalesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SeniorSalesFactory>().As<ISalesFactory>();
            base.Load(builder);
        }
    }
}
