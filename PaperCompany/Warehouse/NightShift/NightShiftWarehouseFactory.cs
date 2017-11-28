using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.NightShift
{
    class NightShiftWarehouseFactory : IWarehouseFactory
    {
        public IDelivery CreateDelivery()
        {
            throw new NotImplementedException();
        }

        public IStock CreateStock()
        {
            throw new NotImplementedException();
        }

        public IWarehouseWorker CreateWarehouseWorker()
        {
            throw new NotImplementedException();
        }
    }
}
