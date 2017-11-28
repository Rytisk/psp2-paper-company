using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse;

namespace WarehouseRepository.Delivery
{
    class InMemoryDeliveryRepository
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

        public void Delete(int deliveryId)
        {
            _deliveries.RemoveAll(x => x.DeliveryId == deliveryId);
        }

        public List<IDelivery> GetAll()
        {
            return _deliveries;
        }

        public IDelivery GetById(int deliveryId)
        {
            return _deliveries.FirstOrDefault(x => x.DeliveryId == deliveryId);
        }
    }
}
