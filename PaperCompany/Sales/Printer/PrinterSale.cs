using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Printer
{
    class PrinterSale : ISale
    {
        private Printer _printer;

        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public int SaleId { get; set; }

        public PrinterSale(Printer printer)
        {
            _printer = printer;
        }

        public IProduct GetProduct()
        {
            return _printer;
        }

        public decimal GetTotal()
        {
            return Quantity * _printer.Price;
        }
    }
}
