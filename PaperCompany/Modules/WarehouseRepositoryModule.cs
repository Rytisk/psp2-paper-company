using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using System.Text;
using System.Threading.Tasks;
using Company.Repository.WarehouseRepositoryInMemory;
using Company.Repository.WarehouseRepositoryApi;

namespace Company.Modules
{
    class WarehouseRepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(new InMemoryDeliveryRepository()).As<IDeliveryRepository>();
            builder.RegisterInstance(new InMemoryProductRepository()).As<IProductRepository>();
            base.Load(builder);
        }
    }
}
