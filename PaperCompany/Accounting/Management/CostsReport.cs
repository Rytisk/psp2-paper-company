using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Management
{
    class CostsReport : IReport
    {
        public string ShortDescription { get; set; }
        public int ReportId { get; set; }

        public decimal GetTotal()
        {
            throw new NotImplementedException();
        }
    }
}
