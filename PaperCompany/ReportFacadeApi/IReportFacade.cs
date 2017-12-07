using PaperCompany.Entities.AccountingApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Facade.ReportFacadeApi
{
    public interface IReportFacade
    {
        IReport WriteReport(string accountantId, string reportDescription, string orderId);
    }
}
