using Autofac;
using PaperCompany.Entities.PaperDivision;
using PaperCompany.Entities.WarehouseApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Modules
{
    public class WarehouseModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PaperDivisionFactory>().As<IWarehouseFactory>();
            base.Load(builder);
        }
    }
}
