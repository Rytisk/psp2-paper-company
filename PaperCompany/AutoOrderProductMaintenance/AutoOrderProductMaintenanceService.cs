using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Services.ProductMaintenanceServiceApi;
using PaperCompany.Repository.WarehouseRepositoryApi;
using PaperCompany.Entities.WarehouseApi;

namespace PaperCompany.Services.AutoOrderProductMaintenance
{
    public class AutoOrderProductMaintenanceService : IProductMaintenanceService
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

        public IDelivery DeliverProductsToWarehouse(int quantity, string source)
        {
            List<IProduct> products = new List<IProduct>();
            for(int i = 0; i < quantity; i++)
            {
                IProduct product = _warehouseFactory.CreateProduct();
                products.Add(product);
                _productRepository.Add(product);
            }
            IDelivery delivery = _warehouseFactory.CreateDelivery();
            delivery.RegisterDelivery(source, WAREHOUSE_ADDRESS, products);
            _deliveryRepository.Add(delivery);
            return delivery;
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

        public List<IProduct> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public IProduct GetProduct(string productId)
        {
            return _productRepository.GetById(productId);
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
