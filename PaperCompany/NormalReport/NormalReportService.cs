using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.AccountingApi;
using Company.Services.ReportServiceApi;
using Company.Repository.AccountingRepositoryApi;

namespace Company.Services.NormalReport
{
    public class NormalReportService : IReportService
    {
        private IAccountingFactory _accountingFactory;
        private IAccountantRepository _accountantRepository;
        private IReportRepository _reportRepository;

        public NormalReportService(IAccountingFactory accountingFactory, IAccountantRepository accountantRepository, IReportRepository reportRepository)
        {
            _accountingFactory = accountingFactory;
            _accountantRepository = accountantRepository;
            _reportRepository = reportRepository;
        }

        public IReport WriteReport(string accountantId, string orderId, List<string> productsIds, decimal unitPrice, string description)
        {
            IAccountant accountant = _accountantRepository.GetById(accountantId);
            accountant.LogAnOrder(productsIds, unitPrice, orderId);
            IReport report = accountant.WriteReport(description);
            _reportRepository.Add(report);
            return report;
        }
    }
}
