using Autofac;
using PaperCompany.Repository.SalesRepositoryApi;
using PaperCompany.Repository.SalesRepositoryInMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Modules
{
    public class SalesRepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(new InMemorySalesmanRepository()).As<ISalesmanRepository>();
            builder.RegisterInstance(new InMemoryOrderRepository()).As<IOrderRepository>();
            base.Load(builder);
        }
    }
}
