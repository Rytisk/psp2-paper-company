using Company.Entities.Warehouse.Api;
using Company.Facade.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.UI.Console.Controllers
{
    public class ProductController
    {
        private IProductFacade _productFacade;

        public ProductController(IProductFacade productFacade)
        {
            _productFacade = productFacade;
        }

        public void DeliverProductsToWarehouse(int quantity, string source)
        {
            _productFacade.DeliverProductsToWarehouse(quantity, source);
        }

        public string GetProduct(string productId)
        {
            var product = _productFacade.GetProduct(productId);
            return string.Format("Name: {0}, Id: {1}, Price: {2}", product.GetName(), product.ProductId, product.GetUnitPrice());
        }

        public string GetAllProducts()
        {
            string productsInfo = string.Empty;
            var products = _productFacade.GetAllProducts();
            foreach(var product in products)
            {
                productsInfo += string.Format("Name: {0}, Id: {1}, Price: {2}", product.GetName(), product.ProductId, product.GetUnitPrice());
            }
            return productsInfo;
        }
    }
}
