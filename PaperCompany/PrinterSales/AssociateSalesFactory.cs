using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Sales.Api;

namespace Company.Entities.Sales.Associate
{
    class AssociateSalesFactory : ISalesFactory
    {
        public IOrder CreateOrder(decimal unitPrice)
        {
            return new SmallOrder(unitPrice);
        }

        public ISalesman CreateSalesman()
        {
            return new AssociateSalesman();
        }
    }
}
