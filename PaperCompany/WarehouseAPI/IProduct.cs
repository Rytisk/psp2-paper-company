using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities.Warehouse.Api
{
    public interface IProduct
    {
        decimal GetUnitPrice();
        string ProductId { get; }
    }
}
