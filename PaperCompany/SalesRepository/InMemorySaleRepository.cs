using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.SalesAPI;
using Company.Facade.SalesRepositoryAPI;

namespace Company.Repository.SalesRepository
{
    class InMemorySaleRepository : ISaleRepository
    {
        private List<ISale> _sales = new List<ISale>();

        public void Add(ISale sale)
        {
            if (!_sales.Any(x => x.SaleId == sale.SaleId))
            {
                _sales.Add(sale);
            }
            else
            {
                throw new Exception("This sale record already exists.");
            }
        }

        public void Delete(int saleId)
        {
            _sales.RemoveAll(x => x.SaleId == saleId);
        }

        public List<ISale> GetAll()
        {
            return _sales;
        }

        public ISale GetById(int saleId)
        {
            return _sales.FirstOrDefault(x => x.SaleId == saleId);
        }
    }
}
