using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Warehouse.Api;
using Company.Repository.Api;
namespace Company.Repository.Warehouse
{
    public class InMemoryDeliveryRepository : IDeliveryRepository
    {
        private List<IDelivery> _deliveries = new List<IDelivery>();

        public void Add(IDelivery delivery)
        {
            if (!_deliveries.Any(x => x.DeliveryId == delivery.DeliveryId))
            {
                _deliveries.Add(delivery);
            }
            else
            {
                throw new Exception("This delivery already exists.");
            }
        }

        public void Delete(string deliveryId)
        {
            _deliveries.RemoveAll(x => x.DeliveryId == deliveryId);
        }

        public List<IDelivery> GetAll()
        {
            return _deliveries;
        }

        public IDelivery GetById(string deliveryId)
        {
            return _deliveries.FirstOrDefault(x => x.DeliveryId == deliveryId);
        }
    }
}
