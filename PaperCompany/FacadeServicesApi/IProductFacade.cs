using Company.Entities.WarehouseApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Facade.Api
{
    public interface IProductFacade
    {
        void DeliverProductsToWarehouse(int quantity, string source);
        IProduct GetProduct(string productId);
        List<IProduct> GetAllProducts();
    }
}
