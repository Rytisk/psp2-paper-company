using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.AccountingApi;

namespace Company.Services.ReportServiceApi
{
    public interface IReportService
    {
        IReport WriteReport(string accountantId, string orderId, List<string> productsIds, decimal unitPrice, string description);
    }
}
