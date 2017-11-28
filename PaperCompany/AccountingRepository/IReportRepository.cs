using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting;

namespace AccountingRepository
{
    interface IReportRepository
    {
        void Add(IReport report);
        void Delete(int reportId);
        IReport GetById(int reportId);
        List<IReport> GetAll();
    }
}
