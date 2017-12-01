using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;
using Company.Facade.Api;
using Company.Services.Api;
using Company.Entities.Sales.Api;

namespace Company.Facade.Services
{
    public class NormalReportFacade : IReportFacade
    {
        private IReportService _reportService;
        private IOrderService _orderService;

        public NormalReportFacade(IReportService reportService, IOrderService orderService)
        {
            _reportService = reportService;
            _orderService = orderService;
        }

        public IReport WriteReport(string accountantId, string reportDescription, string orderId)
        {
            IOrder order = _orderService.GetOrder(orderId);
            return _reportService.WriteReport(accountantId, orderId, order.GetProducts(), order.GetUnitPrice(), reportDescription);
        }
    }
}
