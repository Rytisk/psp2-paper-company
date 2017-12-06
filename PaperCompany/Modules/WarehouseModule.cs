using Autofac;
using Company.Entities.PaperDivision;
using Company.Entities.WarehouseApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Modules
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
