using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Warehouse.Api;

namespace Company.Entities.Warehouse.PrinterDivision
{
    class PrinterDelivery : IDelivery
    {
        public string DeliveryId { get; private set; }

        public PrinterDelivery()
        {
            DeliveryId = new Guid().ToString();
        }

        public string GetDestination()
        {
            throw new NotImplementedException();
        }

        public List<IProduct> GetProducts()
        {
            throw new NotImplementedException();
        }

        public int GetQuantity()
        {
            throw new NotImplementedException();
        }

        public string GetSource()
        {
            throw new NotImplementedException();
        }

        public void RegisterDelivery(string source, string destination, List<IProduct> products)
        {
            throw new NotImplementedException();
        }
    }
}
