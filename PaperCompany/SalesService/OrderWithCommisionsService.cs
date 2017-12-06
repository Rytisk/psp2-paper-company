using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.SalesApi;
using Company.Repository.Api;
using Company.Services.Api;

namespace Company.Services.Sales
{
    public class OrderWithCommisionsService : IOrderService
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

        public IOrder CreateOrder(List<string> productsIds, decimal unitPrice, string salesmanId)
        {
            IOrder order = _salesFactory.CreateOrder(unitPrice);
            foreach (var id in productsIds)
                order.AddProduct(id);

            ISalesman salesman = _salesmanRepository.GetById(salesmanId);
            salesman.AddToYearQuota(order.GetTotalPrice());
            salesman.TakeCommisions(order);
            
            _orderRepository.Add(order);

            return order;
        }

        public List<IOrder> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public IOrder GetOrder(string orderId)
        {
            return _orderRepository.GetById(orderId);
        }
    }
}
