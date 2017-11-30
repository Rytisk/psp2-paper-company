using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;

namespace Company.Entities.Accounting.Management
{
    class CostsReport : IReport
    {
        private string _reportData;

        public string ShortDescription { get; set; }
        public string ReportId { get; private set; }

        public CostsReport(string shortDescription, string reportData)
        {
            ReportId = new Guid().ToString();
            ShortDescription = shortDescription;
            _reportData = reportData;

        }

        public string GetReportInfo()
        {
            return "Costs report: " + _reportData;
        }
    }
}
