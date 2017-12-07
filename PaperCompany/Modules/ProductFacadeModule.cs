using Autofac;
using PaperCompany.Facade.NormalProduct;
using PaperCompany.Facade.ProductFacadeApi;

namespace PaperCompany.Modules
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
