using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entity.AccountingAPI
{
    public interface IReport
    {
        int ReportId { get; set; }
        string ShortDescription { get; set; }

        decimal GetTotal();
    }
}
