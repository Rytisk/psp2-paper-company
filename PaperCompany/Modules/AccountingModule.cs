using Autofac;
using Company.Entities.AccountingApi;
using Company.Entities.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Modules
{
    public class AccountingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FinanceAccountingFactory>().As<IAccountingFactory>();
            base.Load(builder);
        }
    }
}
