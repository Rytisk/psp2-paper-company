using Company.Facade.ReportFacadeApi;
using Company.UI.Api.Views;
using Company.UI.Api.Controllers;

namespace Company.UI.Console.Controllers
{
    public class AccountantController : IAccountantController
    {
        private IReportFacade _reportFacade;
        private IAccountantView _view;

        public AccountantController(IReportFacade reportFacade, IAccountantView view)
        {
            _reportFacade = reportFacade;
            _view = view;
            _view.AddController(this);
        }

        public void WriteReport(string accountantId, string reportDescription, string orderId)
        {
            var report = _reportFacade.WriteReport(accountantId, reportDescription, orderId);
            _view.ShowReportDetails(report.ReportId, report.GetReportInfo());
        }

        public void LoadView()
        {
            _view.ShowMenu();
        }
    }
}
