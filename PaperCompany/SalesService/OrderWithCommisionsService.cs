using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Sales.Api;
using Company.Repository.Api;
using Company.Services.Api;

namespace Company.Services.Sales
{
    class OrderWithCommisionsService : IOrderService
    {
        private ISalesFactory _salesFactory;
        private ISalesmanRepository _salesmanRepository;
        private IOrderRepository _orderRepository;

        public OrderWithCommisionsService(ISalesFactory salesFactory, ISalesmanRepository salesmanRepository, IOrderRepository orderRepository)
        {
            _salesFactory = salesFactory;
            _salesmanRepository = salesmanRepository;
            _orderRepository = orderRepository;
        }

        public void CreateOrder(List<string> productsIds, decimal unitPrice)
        {
            IOrder order = _salesFactory.CreateOrder();
            


            _orderRepository.Add(order);
        }
    }
}
