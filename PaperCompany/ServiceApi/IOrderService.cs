using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Api
{
    public interface IOrderService
    {
        void CreateOrder(List<string> productsIds, decimal unitPrice, string salesmanId);
    }
}
