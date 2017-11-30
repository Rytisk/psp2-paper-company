using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities.Sales.Api
{
    public interface ISalesFactory
    {
        IOrder CreateOrder(decimal unitPrice);
        ISalesman CreateSalesman();
    }
}
