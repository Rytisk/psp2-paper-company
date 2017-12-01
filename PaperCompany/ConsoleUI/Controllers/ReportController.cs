using Company.Entities.Accounting.Api;
using Company.Facade.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.UI.Console.Controllers
{
    public class ReportController
    {
        private IReportFacade _reportFacade;

        public ReportController(IReportFacade reportFacade)
        {
            _reportFacade = reportFacade;
        }

        public string WriteReport(string accountantId, string reportDescription, string orderId)
        {
            var report = _reportFacade.WriteReport(accountantId, reportDescription, orderId);
            return string.Format("ReportId: {0}, Info: {1}", report.ReportId, report.GetReportInfo());
        }
    }
}
