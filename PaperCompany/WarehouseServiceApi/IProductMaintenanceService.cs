using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Warehouse.Api;

namespace Company.Services.Api
{
    public interface IProductMaintenanceService
    {
        bool EnoughProducts(int quantity);
        IDelivery DeliverProductsToWarehouse(int quantity, string source);
        List<IProduct> GetAllProducts();
        IProduct GetProduct(string productId);
    }
}
