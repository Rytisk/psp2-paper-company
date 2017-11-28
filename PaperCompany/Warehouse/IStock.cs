using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    interface IStock
    {
        DateTime ManufactureDate { get; set; }
        int QuantityInStock { get; set; }
        int ProductID { get; set; }
    }
}
