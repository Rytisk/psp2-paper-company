using Autofac;
using PaperCompany.Repository.AccountingRepositoryApi;
using PaperCompany.Repository.AccountingRepositoryInMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Modules
{
    public class AccountingRepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(new InMemoryAccountantRepository()).As<IAccountantRepository>();
            builder.RegisterInstance(new InMemoryReportRepository()).As<IReportRepository>();
            base.Load(builder);
        }
    }
}
