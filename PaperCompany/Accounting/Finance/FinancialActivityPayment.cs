using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Finance
{
    class FinancialActivityPayment : IPayment
    {
        public string ClientAccountNumber { get; set; }
        public int PaymentId { get; set; }
    }
}
