using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.SalesAPI;

namespace Company.Entity.PrinterSales
{
    class PrinterSalesFactory : ISalesFactory
    {
        public IProduct CreateProduct()
        {
            throw new NotImplementedException();
        }

        public ISale CreateSale()
        {
            throw new NotImplementedException();
        }
    }
}
