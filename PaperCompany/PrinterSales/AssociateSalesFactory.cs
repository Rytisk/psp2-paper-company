using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.SalesApi;

namespace PaperCompany.Entities.Associate
{
    public class AssociateSalesFactory : ISalesFactory
    {
        public IOrder CreateOrder(decimal unitPrice)
        {
            return new SmallOrder(unitPrice);
        }

        public ISalesman CreateSalesman(string firstName, string lastName)
        {
            return new AssociateSalesman(firstName, lastName);
        }
    }
}
