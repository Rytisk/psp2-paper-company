using Autofac;
using Company.Repository.AccountingRepositoryApi;
using Company.Repository.AccountingRepositoryInMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Modules
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
