using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Entities.AccountingApi
{
    public interface IReport
    {
        string ReportId { get; }
        string ShortDescription { get; set; }

        string GetReportInfo();
    }
}
