using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Services.Api;
using Company.Entities.Sales.Api;
using Company.Repository.Api;

namespace Company.Services.Sales
{
    public class NormalSalesmanService : ISalesmanService
    {
        private ISalesFactory _salesFactory;
        private ISalesmanRepository _salesmanRepository;
     

        public NormalSalesmanService(ISalesFactory salesFactory, ISalesmanRepository salesmanRepository)
        {
            _salesFactory = salesFactory;
            _salesmanRepository = salesmanRepository;
        }

        public ISalesman CreateSalesman(string firstName, string lastName)
        {
            ISalesman salesman = _salesFactory.CreateSalesman(firstName, lastName);
            _salesmanRepository.Add(salesman);
            return salesman;
        }

        public List<ISalesman> GetAllSalesmans()
        {
            return _salesmanRepository.GetAll();
        }
    }
}
