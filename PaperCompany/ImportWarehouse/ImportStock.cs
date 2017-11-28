using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.WarehouseAPI;

namespace Company.Entity.ImportWarehouse
{
    class ImportStock : IStock
    {
        public DateTime ManufactureDate { get; set; }
        public int QuantityInStock { get; set; }
        public int ProductID { get; set; }
        public int StockId { get; set; }
    }
}
