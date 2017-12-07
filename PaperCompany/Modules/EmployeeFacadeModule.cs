using Autofac;
using PaperCompany.Facade.EmployeeFacadeApi;
using PaperCompany.Facade.NormalEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Modules
{
    public class EmployeeFacadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NormalEmployeeFacade>().As<IEmployeeFacade>();
            base.Load(builder);
        }
    }
}
