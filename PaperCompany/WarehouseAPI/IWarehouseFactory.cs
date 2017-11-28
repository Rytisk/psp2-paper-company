using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entity.WarehouseAPI
{
    public interface IWarehouseFactory
    {
        IDelivery CreateDelivery();
        IStock CreateStock();
    }
}
