using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales;

namespace SalesRepository.Product
{
    class InMemoryProductRepository : IProductRepository
    {
        private List<IProduct> _products = new List<IProduct>();

        public void Add(IProduct product)
        {
            if(!_products.Any(x => x.ProductId == product.ProductId))
            {
                _products.Add(product);
            }
            else
            {
                throw new Exception("This product already exists.");
            }
        }

        public void Delete(int productId)
        {
            _products.RemoveAll(x => x.ProductId == productId);
        }

        public List<IProduct> GetAll()
        {
            return _products;
        }

        public IProduct GetById(int productId)
        {
            return _products.FirstOrDefault(x => x.ProductId == productId);
        }
    }
}
