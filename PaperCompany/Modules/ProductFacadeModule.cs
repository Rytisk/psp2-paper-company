using Autofac;
using Company.Facade.NormalProduct;
using Company.Facade.ProductFacadeApi;

namespace Company.Modules
{
    public class ProductFacadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NormalProductFacade>().As<IProductFacade>();
            base.Load(builder);
        }
    }
}
