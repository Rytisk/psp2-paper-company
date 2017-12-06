using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.SalesApi;

namespace Company.Repository.SalesRepositoryApi
{
    public interface IOrderRepository
    {
        void Add(IOrder order);
        void Delete(string order);
        IOrder GetById(string order);
        List<IOrder> GetAll();
    }
}
