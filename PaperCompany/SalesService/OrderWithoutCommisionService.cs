﻿using Company.Entities.Sales.Api;
using Company.Repository.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Sales
{
    class OrderWithoutCommisionService
    {
        private ISalesFactory _salesFactory;
        private ISalesmanRepository _salesmanRepository;
        private IOrderRepository _orderRepository;

        public OrderWithoutCommisionService(ISalesFactory salesFactory, ISalesmanRepository salesmanRepository, IOrderRepository orderRepository)
        {
            _salesFactory = salesFactory;
            _salesmanRepository = salesmanRepository;
            _orderRepository = orderRepository;
        }

        public void CreateOrder(List<string> productsIds, decimal unitPrice, string salesmanId)
        {
            IOrder order = _salesFactory.CreateOrder(unitPrice);
            foreach (var id in productsIds)
                order.AddProduct(id);

            ISalesman salesman = _salesmanRepository.GetById(salesmanId);
            salesman.AddToYearQuota(order.GetTotalPrice());

            _orderRepository.Add(order);
        }
    }
}