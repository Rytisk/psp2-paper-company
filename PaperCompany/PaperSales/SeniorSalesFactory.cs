using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.SalesApi;

namespace PaperCompany.Entities.Senior
{
    public class SeniorSalesFactory : ISalesFactory
    {
        public IOrder CreateOrder(decimal unitPrice)
        {
            return new BigOrder(unitPrice);
        }

        public ISalesman CreateSalesman(string firstName, string lastName)
        {
            return new SeniorSalesman(firstName, lastName);
        }
    }
}
