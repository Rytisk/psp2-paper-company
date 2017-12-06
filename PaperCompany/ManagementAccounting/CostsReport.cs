using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.AccountingApi;

namespace Company.Entities.Management
{
    class CostsReport : IReport
    {
        private string _reportData;

        public string ShortDescription { get; set; }
        public string ReportId { get; private set; }

        public CostsReport(string shortDescription, string reportData)
        {
            ReportId = Guid.NewGuid().ToString();
            ShortDescription = shortDescription;
            _reportData = reportData;

        }

        public string GetReportInfo()
        {
            return "Costs report: " + _reportData;
        }
    }
}
