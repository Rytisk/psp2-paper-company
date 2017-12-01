using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Facade.Api;
using Company.Entities.Sales.Api;

namespace Company.UI.Console.Controllers
{
    public class OrderController
    {
        private IOrderFacade _orderFacade;

        public OrderController(IOrderFacade orderFacade)
        {
            _orderFacade = orderFacade;
        }

        public string CreateOrder(List<string> productIds, decimal unitPrice, string salesmanId)
        {
            IOrder order = _orderFacade.CreateOrder(productIds, unitPrice, salesmanId);

            return string.Format("OrderId: {0}, Product quantity: {1}, Total price: {2}", order.OrderId, order.GetQuantity(), order.GetTotalPrice());
        }
    }
}
