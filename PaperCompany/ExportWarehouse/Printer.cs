using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.WarehouseApi;

namespace PaperCompany.Entities.PrinterDivision
{
    class Printer : IProduct
    {
        private const decimal UNIT_PRICE = 50.0m;
        public string ProductId { get; private set; }

        public Printer()
        {
            ProductId = Guid.NewGuid().ToString();
        }

        public decimal GetUnitPrice()
        {
            return UNIT_PRICE;
        }

        public string GetName()
        {
            return "Printer";
        }
    }
}
