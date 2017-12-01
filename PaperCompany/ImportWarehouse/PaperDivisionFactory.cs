using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Warehouse.Api;

namespace Company.Entities.Warehouse.PaperDivision
{
    public class PaperDivisionFactory : IWarehouseFactory
    {
        public IDelivery CreateDelivery()
        {
            return new PaperDelivery();
        }

        public IProduct CreateProduct()
        {
            return new Paper();
        }
    }
}
