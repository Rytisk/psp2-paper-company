using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.AccountingApi;

namespace PaperCompany.Repository.AccountingRepositoryApi
{
    public interface IReportRepository
    {
        void Add(IReport report);
        void Delete(string reportId);
        IReport GetById(string reportId);
        List<IReport> GetAll();
    }
}
