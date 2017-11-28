using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Import
{
    class ImportWarehouseFactory : IWarehouseFactory
    {
        public IDelivery CreateDelivery()
        {
            throw new NotImplementedException();
        }

        public IStock CreateStock()
        {
            throw new NotImplementedException();
        }
    }
}
