using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.SalesApi;

namespace Company.Services.OrderServiceApi
{
    public interface IOrderService
    {
        IOrder CreateOrder(List<string> productsIds, decimal unitPrice, string salesmanId);
        IOrder GetOrder(string orderId);
        List<IOrder> GetAllOrders();
    }
}
