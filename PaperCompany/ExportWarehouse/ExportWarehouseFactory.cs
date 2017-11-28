using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.WarehouseAPI;

namespace Company.Entity.ExportWarehouse
{
    class ExportWarehouseFactory : IWarehouseFactory
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
