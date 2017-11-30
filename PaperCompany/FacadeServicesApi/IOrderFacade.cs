using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Sales.Api;

namespace Company.Facade.Api
{
    public interface IOrderFacade
    {
        IOrder CreateOrder(List<string> prodctsIds, decimal unitPrice, string salesmanId);
    }
}
