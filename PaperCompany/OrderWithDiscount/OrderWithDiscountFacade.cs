using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.SalesApi;
using PaperCompany.Facade.OrderFacadeApi;
using PaperCompany.Services.OrderServiceApi;
using PaperCompany.Services.ProductMaintenanceServiceApi;

namespace PaperCompany.Facade.OrderWithoutDiscount
{
    public class OrderWithDiscountFacade : IOrderFacade
    {
        private decimal DISCOUNT = 0.05m;
        private IOrderService _orderService;
        private IProductMaintenanceService _productMaintenanceService;

        public OrderWithDiscountFacade(IOrderService orderService, IProductMaintenanceService productMaintenanceService)
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

            decimal unitPriceWithDiscount = unitPrice * DISCOUNT;
            return _orderService.CreateOrder(prodctsIds, unitPriceWithDiscount, salesmanId);
        }
    }
}
