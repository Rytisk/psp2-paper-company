using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.WarehouseApi;

namespace Company.Repository.WarehouseRepositoryApi
{
    public interface IProductRepository
    {
        void Add(IProduct product);
        void Delete(string productId);
        IProduct GetById(string productId);
        List<IProduct> GetAll();
    }
}
