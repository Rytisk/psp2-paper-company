using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Sales.Api;

namespace Company.Repository.Api
{
    public interface ISalesmanRepository
    {
        void Add(ISalesman salesman);
        void Delete(string salesmanId);
        ISalesman GetById(string salesmanId);
        List<ISalesman> GetAll();
    }
}
