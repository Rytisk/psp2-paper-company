using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Import
{
    class ImportStock : IStock
    {
        public DateTime ManufactureDate { get; set; }
        public int QuantityInStock { get; set; }
        public int ProductID { get; set; }
        public int StockId { get; set; }
    }
}
