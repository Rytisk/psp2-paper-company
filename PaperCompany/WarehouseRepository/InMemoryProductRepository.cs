using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Warehouse.Api;
using Company.Repository.Api;

namespace Company.Repository.Warehouse
{
    public class InMemoryProductRepository : IProductRepository
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

        public void Delete(string productId)
        {
            _products.RemoveAll(x => x.ProductId == productId);
        }

        public List<IProduct> GetAll()
        {
            return _products;
        }

        public IProduct GetById(string productId)
        {
            return _products.FirstOrDefault(x => x.ProductId == productId);
        }
    }
}
