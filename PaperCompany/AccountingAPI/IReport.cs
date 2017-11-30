using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities.Accounting.Api
{
    public interface IReport
    {
        string ReportId { get; }
        string ShortDescription { get; set; }

        decimal GetTotal();
    }
}
