using Autofac;
using Company.Services.AccountantServiceApi;
using Company.Services.NormalAccountant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Modules
{
    public class AccountantModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NormalAccountantService>().As<IAccountantService>();
            base.Load(builder);
        }
    }
}
