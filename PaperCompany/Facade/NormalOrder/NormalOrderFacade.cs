using PaperCompany.Entities.SalesApi;
using PaperCompany.Facade.OrderFacadeApi;
using PaperCompany.Services.OrderServiceApi;
using PaperCompany.Services.ProductMaintenanceServiceApi;
using System;
using System.Collections.Generic;

namespace PaperCompany.Facade.NormalOrder
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
            if (!_productMaintenanceService.EnoughProducts(prodctsIds.Count))
            {
                throw new Exception("Not enough products in the warehouse!");
            }
            return _orderService.CreateOrder(prodctsIds, unitPrice, salesmanId);
        }
    }
}
