using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Warehouse.Api;

namespace Company.Entities.Warehouse.PaperDivision
{
    class Paper : IProduct
    {
        private const decimal UNIT_PRICE = 20.5m; 

        public string ProductId { get; private set; }

        public Paper()
        {
            ProductId = new Guid().ToString();
        }

        public decimal GetUnitPrice()
        {
            return UNIT_PRICE;
        }
    }
}
