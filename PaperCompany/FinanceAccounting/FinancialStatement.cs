using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;

namespace Company.Entities.Accounting.Finance
{
    class FinancialStatement : IReport
    {
        public string ShortDescription { get; set; }
        public string ReportId { get; private set; }

        public FinancialStatement(string shortDescription, string reportData)
        {
            ReportId = new Guid().ToString();
        }

        public string GetReportInfo()
        {
            throw new NotImplementedException();
        }
    }
}
