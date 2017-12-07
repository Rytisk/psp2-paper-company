using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Entities.SalesApi
{
    public interface ISalesman
    {
        string SalesmanId { get; }
        string FirstName { get; }
        string LastName { get; }
        decimal GetYearQuota();
        void TakeCommisions(IOrder order);
        void AddToYearQuota(decimal moneyEarned);
        decimal GetCommisions();
    }
}
