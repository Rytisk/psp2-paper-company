using Company.Entities.AccountingApi;
using Company.Facade.ReportFacadeApi;
using Company.Services.OrderServiceApi;
using Company.Services.ReportServiceApi;
using Company.Entities.SalesApi;
using Company.Integration.MailApi;

namespace Company.Facade.StandardReport
{
    public class StandardReportFacade : IReportFacade
    {
        private IReportService _reportService;
        private IOrderService _orderService;
        private IMailSender _mailSender;

        public StandardReportFacade(IReportService reportService, IOrderService orderService, IMailSender mailSender)
        {
            _reportService = reportService;
            _orderService = orderService;
            _mailSender = mailSender;
        }

        public IReport WriteReport(string accountantId, string reportDescription, string orderId)
        {
            IOrder order = _orderService.GetOrder(orderId);
            _mailSender.SendMail("autobot@gmail.com", "manager@gmail.com", "here", "there", "msg");
            return _reportService.WriteReport(accountantId, orderId, order.GetProducts(), order.GetUnitPrice(), reportDescription);
        }
    }
}
