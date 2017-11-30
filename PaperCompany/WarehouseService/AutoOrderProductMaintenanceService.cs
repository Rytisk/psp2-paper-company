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
    class AutoOrderProductMaintenanceService : IProductMaintenanceService
    {
        private const int LIMIT = 5;
        private const int AUTO_DELIVERY_UNIT_QUANTITY = 2;
        private const string WAREHOUSE_ADDRESS = "<warehouse address>";

        private IWarehouseFactory _warehouseFactory;
        private IProductRepository _productRepository;
        private IDeliveryRepository _deliveryRepository;

        public AutoOrderProductMaintenanceService(IWarehouseFactory warehouseFactory, IProductRepository productRepository, IDeliveryRepository deliveryRepository)
        {
            _warehouseFactory = warehouseFactory;
            _productRepository = productRepository;
            _deliveryRepository = deliveryRepository;
        }

        public bool EnoughProducts(int quantity)
        {
            bool isEnough;
            int inWarehouseQuantity = _productRepository.GetAll().Count;
            if (inWarehouseQuantity > quantity)
            {
                if(inWarehouseQuantity - quantity < LIMIT)
                {
                    AutoDeliver();
                }
                isEnough = true;
            }
            else
            {
                AutoDeliver();
                isEnough = false;
            }

            return isEnough;
        }

        private void AutoDeliver()
        {
            IDelivery delivery = _warehouseFactory.CreateDelivery();
            
            List<IProduct> products = new List<IProduct>();
            for(int i = 0; i < AUTO_DELIVERY_UNIT_QUANTITY; i++)
            {
                IProduct product = _warehouseFactory.CreateProduct();
                products.Add(product);
                _productRepository.Add(product);
            }

            delivery.RegisterDelivery("", WAREHOUSE_ADDRESS, products);
            _deliveryRepository.Add(delivery);
        }
    }
}
