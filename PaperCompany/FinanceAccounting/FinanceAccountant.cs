using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.AccountingApi;

namespace PaperCompany.Entities.Finance
{
    public class FinanceAccountant : IAccountant
    {
        private string _reportData = string.Empty;

        public string AccountantId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public FinanceAccountant(string firstName, string lastName)
        {
            AccountantId = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
        }

        public IReport WriteReport(string description)
        {
           return new FinancialStatement(description, _reportData);
        }

        public void LogAnOrder(List<string> productsIds, decimal unitPrice, string orderId)
        {
            _reportData = string.Format("OrderId: {0}, products quantity: {1}, unitPrice: {2}, totalPrice: {3}.\n", orderId, productsIds.Count, unitPrice, unitPrice * productsIds.Count);
        }
    }
}
