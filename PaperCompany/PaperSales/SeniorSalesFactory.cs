using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Sales.Api;

namespace Company.Entities.Sales.Senior
{
    class SeniorSalesFactory : ISalesFactory
    {
        public IOrder CreateOrder(decimal unitPrice)
        {
            return new BigOrder(unitPrice);
        }

        public ISalesman CreateSalesman()
        {
            return new SeniorSalesman();
        }
    }
}
