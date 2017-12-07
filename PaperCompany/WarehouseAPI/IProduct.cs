using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Entities.WarehouseApi
{
    public interface IProduct
    {
        decimal GetUnitPrice();
        string ProductId { get; }
        string GetName();
    }
}
