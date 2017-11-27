using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Printer
{
    class PrinterSale : ISale
    {
        public int Quantity { get; set; }
        public IProduct Product { get; set; }
        public string CustomerName { get; set; }

        public decimal GetTotal()
        {
            return Quantity * Product.Price;
        }
    }
}
