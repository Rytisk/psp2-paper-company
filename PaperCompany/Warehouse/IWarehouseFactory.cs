using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    interface IWarehouseFactory
    {
        IDelivery CreateDelivery();
        IWarehouseWorker CreateWarehouseWorker();
        IStock CreateStock();
    }
}
