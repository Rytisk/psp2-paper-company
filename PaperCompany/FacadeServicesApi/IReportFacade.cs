using Company.Entities.Accounting.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Facade.Api
{
    public interface IReportFacade
    {
        IReport WriteReport(string accountantId, string reportDescription, string orderId);
    }
}
