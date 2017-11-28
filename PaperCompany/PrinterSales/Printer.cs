using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.SalesAPI;

namespace Company.Entity.PrinterSales
{
    class Printer : IProduct
    {
        public string Name { get; set; }
        public string Supplier { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
    }
}
