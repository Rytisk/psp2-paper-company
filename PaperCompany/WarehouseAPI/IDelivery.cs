using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities.Warehouse.Api
{
    public interface IDelivery
    {
        string GetSource();
        string GetDestination();
        int GetQuantity();
        List<IProduct> GetProducts();
        string DeliveryId { get; }

        void RegisterDelivery(string source, string destination, List<IProduct> products);
    }
}
