using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    public interface ISalesFactory
    {
        IProduct CreateProduct();
        ISale CreateSale();
    }
}
