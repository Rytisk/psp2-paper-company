using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities.SalesApi
{
    public interface IOrder
    {
        string OrderId { get; }
        List<string> GetProducts();
        int GetQuantity();
        decimal GetTotalPrice();
        void AddProduct(string productId);
        decimal GetUnitPrice();
    }
}
