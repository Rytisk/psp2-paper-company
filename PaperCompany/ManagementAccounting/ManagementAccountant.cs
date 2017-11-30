using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Accounting.Api;

namespace Company.Entities.Accounting.Management
{
    class ManagementAccountant : IAccountant
    {
        private string _reportData;

        public string AccountantId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ManagementAccountant()
        {
            AccountantId = new Guid().ToString();
        }

        public IReport WriteReport(string description)
        {
            return new CostsReport(description, _reportData);
        }

        public void LogAnOrder(List<string> productsIds, decimal unitPrice, string orderId)
        {
            _reportData += string.Format("OrderId: {0}, products quantity: {1}, unitPrice: {2}, totalPrice: {3}.\n", orderId, productsIds.Count, unitPrice, unitPrice * productsIds.Count);
        }
    }
}
