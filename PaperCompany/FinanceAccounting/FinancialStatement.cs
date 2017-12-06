using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.AccountingApi;

namespace Company.Entities.Finance
{
    class FinancialStatement : IReport
    {
        private string _reportData;

        public string ShortDescription { get; set; }
        public string ReportId { get; private set; }

        public FinancialStatement(string shortDescription, string reportData)
        {
            ShortDescription = shortDescription;
            _reportData = reportData;
            ReportId = Guid.NewGuid().ToString();
        }

        public string GetReportInfo()
        {
            return "Financial statement: " + _reportData;
        }
    }
}
