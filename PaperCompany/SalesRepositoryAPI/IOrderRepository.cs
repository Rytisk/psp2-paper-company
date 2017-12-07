using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.Entities.SalesApi;

namespace PaperCompany.Repository.SalesRepositoryApi
{
    public interface IOrderRepository
    {
        void Add(IOrder order);
        void Delete(string order);
        IOrder GetById(string order);
        List<IOrder> GetAll();
    }
}
