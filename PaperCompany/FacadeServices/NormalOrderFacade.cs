using Company.Entities.Accounting.Api;
using Company.Entities.Sales.Api;
using Company.Entities.Warehouse.Api;
using Company.Facade.Api;
using Company.Integration.Api;
using Company.Services.Api;
using System;
using System.Collections.Generic;

namespace Company.Facade.Services
{
    public class NormalOrderFacade : IOrderFacade
    {
        private IOrderService _orderService;
        private IProductMaintenanceService _productMaintenanceService;

        public NormalOrderFacade(IOrderService orderService, IProductMaintenanceService productMaintenanceService)
        {
            _orderService = orderService;
            _productMaintenanceService = productMaintenanceService;
        }

        public IOrder CreateOrder(List<string> prodctsIds, decimal unitPrice, string salesmanId)
        {
            if(!_productMaintenanceService.EnoughProducts(prodctsIds.Count))
            {
                throw new Exception("Not enough products in the warehouse!");
            }
            
            return _orderService.CreateOrder(prodctsIds, unitPrice, salesmanId);
        }
    }
}
