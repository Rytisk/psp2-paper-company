using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Warehouse.Api;

namespace Company.Entities.Warehouse.PrinterDivision
{
    public  class PrinterDivisionFactory : IWarehouseFactory
    {
        public IDelivery CreateDelivery()
        {
            return new PrinterDelivery();
        }

        public IProduct CreateProduct()
        {
            return new Printer();
        }
    }
}
