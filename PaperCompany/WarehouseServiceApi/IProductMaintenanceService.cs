using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.WarehouseApi;

namespace Company.Services.ProductMaintenanceServiceApi
{
    public interface IProductMaintenanceService
    {
        bool EnoughProducts(int quantity);
        IDelivery DeliverProductsToWarehouse(int quantity, string source);
        List<IProduct> GetAllProducts();
        IProduct GetProduct(string productId);
    }
}
