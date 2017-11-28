using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.AccountingAPI;

namespace Company.Facade.AccountingRepositoryAPI
{
    public interface IReportRepository
    {
        void Add(IReport report);
        void Delete(int reportId);
        IReport GetById(int reportId);
        List<IReport> GetAll();
    }
}
