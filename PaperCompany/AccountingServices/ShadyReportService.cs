using Company.Entities.Accounting.Api;
using Company.Repository.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Accounting
{
    class ShadyReportService
    {
        private IAccountingFactory _accountingFactory;
        private IAccountantRepository _accountantRepository;
        private IReportRepository _reportRepository;

        public ShadyReportService(IAccountingFactory accountingFactory, IAccountantRepository accountantRepository, IReportRepository reportRepository)
        {
            _accountingFactory = accountingFactory;
            _accountantRepository = accountantRepository;
            _reportRepository = reportRepository;
        }

        public IReport WriteReport(string accountantId, string orderId, List<string> productsIds, decimal unitPrice, string description)
        {
            IAccountant accountant = _accountantRepository.GetById(accountantId);
            IReport report = accountant.WriteReport(description);
            _reportRepository.Add(report);
            return report;
        }
    }
}
