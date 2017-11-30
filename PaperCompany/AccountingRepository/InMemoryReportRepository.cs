using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;
using Company.Repository.Api;

namespace Company.Repository.Accounting
{
    class InMemoryReportRepository : IReportRepository
    {
        private List<IReport> _reports = new List<IReport>();

        public void Add(IReport report)
        {
            if (!_reports.Any(x => x.ReportId == report.ReportId))
            {
                _reports.Add(report);
            }
            else
            {
                throw new Exception("This report already exists.");
            }
        }

        public void Delete(string reportId)
        {
            _reports.RemoveAll(x => x.ReportId == reportId);
        }

        public List<IReport> GetAll()
        {
            return _reports;
        }

        public IReport GetById(string reportId)
        {
            return _reports.FirstOrDefault(x => x.ReportId == reportId);
        }
    }
}
