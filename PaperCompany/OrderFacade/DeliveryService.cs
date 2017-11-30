using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Warehouse.Api;
using Company.Repository.Api;

namespace Company.Facade.DeliverServiceFacade
{
    public class DeliveryService
    {
        private IWarehouseFactory _warehouseFactory;
        private IDeliveryRepository _deliveryRepository;
        private IProductRepository _productRepository;

        public DeliveryService(IWarehouseFactory warehouseFactory, IDeliveryRepository deliveryRepository, IProductRepository productRepository)
        {
            _warehouseFactory = warehouseFactory;
            _deliveryRepository = deliveryRepository;
            _productRepository = productRepository;
        }

        void MakeADelivery(string source, string destination, int deliveryId, int productId)
        {
            IDelivery delivery = _warehouseFactory.CreateDelivery();


            _deliveryRepository.Add(delivery);            
        }
    }
}
