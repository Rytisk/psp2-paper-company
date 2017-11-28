using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entity.SalesAPI
{
    public interface ISalesFactory
    {
        IProduct CreateProduct();
        ISale CreateSale();
    }
}
