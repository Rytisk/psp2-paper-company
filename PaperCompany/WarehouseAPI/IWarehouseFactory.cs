using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities.WarehouseApi
{
    public interface IWarehouseFactory
    {
        IDelivery CreateDelivery();
        IProduct CreateProduct();
    }
}
