using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.SalesApi;

namespace Company.Facade.OrderFacadeApi
{
    public interface IOrderFacade
    {
        IOrder CreateOrder(List<string> prodctsIds, decimal unitPrice, string salesmanId);
    }
}
