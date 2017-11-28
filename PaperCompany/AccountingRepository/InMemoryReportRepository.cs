using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.AccountingAPI;
using Company.Facade.AccountingRepositoryAPI;

namespace Company.Repository.AccountingRepository
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

        public void Delete(int reportId)
        {
            _reports.RemoveAll(x => x.ReportId == reportId);
        }

        public List<IReport> GetAll()
        {
            return _reports;
        }

        public IReport GetById(int reportId)
        {
            return _reports.FirstOrDefault(x => x.ReportId == reportId);
        }
    }
}
