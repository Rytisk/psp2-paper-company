using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Warehouse.Api;

namespace Company.Entities.Warehouse.PrinterDivision
{
    public class PrinterDelivery : IDelivery
    {
        private string _destination;
        private string _source;
        private List<IProduct> _products;

        public string DeliveryId { get; private set; }

        public PrinterDelivery()
        {
            DeliveryId = Guid.NewGuid().ToString();
        }

        public string GetDestination()
        {
            return _destination;
        }

        public List<IProduct> GetProducts()
        {
            return _products;
        }

        public int GetQuantity()
        {
            return _products.Count;
        }

        public string GetSource()
        {
            return _source;
        }

        public void RegisterDelivery(string source, string destination, List<IProduct> products)
        {
            _source = source;
            _destination = destination;
            _products = products;
        }
    }
}
