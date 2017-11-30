using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Sales.Api;
using Company.Repository.Api;

namespace Company.Repository.Sales
{
    class InMemoryOrderRepository : IOrderRepository
    {
        private List<IOrder> _orders = new List<IOrder>();

        public void Add(IOrder order)
        {
            if (!_orders.Any(x => x.OrderId == order.OrderId))
            {
                _orders.Add(order);
            }
            else
            {
                throw new Exception("This order already exists.");
            }
        }

        public void Delete(string orderId)
        {
            _orders.RemoveAll(x => x.OrderId == orderId);
        }

        public List<IOrder> GetAll()
        {
            return _orders;
        }

        public IOrder GetById(string orderId)
        {
            return _orders.FirstOrDefault(x => x.OrderId == orderId);
        }
    }
}
