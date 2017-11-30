using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities.Accounting.Api
{
    public interface IAccountant
    {
        string AccountantId { get; }
        string FirstName { get; set; }
        string LastName { get; set; }

        IReport WriteReport(string description);

        void LogAnOrder(List<string> productsIds, decimal unitPrice, string orderId);
    }
}
