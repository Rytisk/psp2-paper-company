using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Services.Api;
using Company.Repository.Api;
using Company.Entities.Warehouse.Api;

namespace Company.Services.Warehouse
{
    class NormalProductMaintenanceService : IProductMaintenanceService
    {
        private const int LIMIT = 5;
        private const int AUTO_DELIVERY_UNIT_QUANTITY = 2;
        private const string WAREHOUSE_ADDRESS = "<warehouse address>";

        private IWarehouseFactory _warehouseFactory;
        private IProductRepository _productRepository;
        private IDeliveryRepository _deliveryRepository;

        public NormalProductMaintenanceService(IWarehouseFactory warehouseFactory, IProductRepository productRepository, IDeliveryRepository deliveryRepository)
        {
            _warehouseFactory = warehouseFactory;
            _productRepository = productRepository;
            _deliveryRepository = deliveryRepository;
        }

        public bool EnoughProducts(int quantity)
        {
            return _productRepository.GetAll().Count > quantity;            
        }
    }
}
