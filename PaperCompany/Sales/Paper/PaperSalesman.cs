using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Paper
{
    class PaperSalesman : ISalesman
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal SalesQuota { get; set; }

        public void MakeSale(ISale sale)
        {
            SalesQuota += sale.GetTotal();
        }
    }
}
