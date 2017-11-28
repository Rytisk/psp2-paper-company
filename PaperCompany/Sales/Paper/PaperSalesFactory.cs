using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Paper
{
    class PaperSalesFactory : ISalesFactory
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
