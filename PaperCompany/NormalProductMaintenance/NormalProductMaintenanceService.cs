using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Services.ProductMaintenanceServiceApi;
using PaperCompany.Repository.WarehouseRepositoryApi;
using PaperCompany.Entities.WarehouseApi;

namespace PaperCompany.Services.NormalProductMaintenance
{
    public class NormalProductMaintenanceService : IProductMaintenanceService
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

        public List<IProduct> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public IProduct GetProduct(string productId)
        {
            return _productRepository.GetById(productId);
        }

        public IDelivery DeliverProductsToWarehouse(int quantity, string source)
        {
            List<IProduct> products = new List<IProduct>();
            for (int i = 0; i < quantity; i++)
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
    }
}
