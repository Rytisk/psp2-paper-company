using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entity.WarehouseAPI
{
    public interface IStock
    {
        int StockId { get; set; }
        DateTime ManufactureDate { get; set; }
        int QuantityInStock { get; set; }
        int ProductID { get; set; }
    }
}
