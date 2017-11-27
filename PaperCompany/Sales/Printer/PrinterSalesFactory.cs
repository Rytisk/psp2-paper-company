using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Printer
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

        public ISalesman CreateSalesman()
        {
            throw new NotImplementedException();
        }
    }
}
