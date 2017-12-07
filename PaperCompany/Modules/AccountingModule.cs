using Autofac;
using PaperCompany.Entities.AccountingApi;
using PaperCompany.Entities.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Modules
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
