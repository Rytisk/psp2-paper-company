using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales;

namespace SalesRepository
{
    interface ISaleRepository
    {
        void Add(ISale sale);
        void Delete(int saleId);
        ISale GetById(int saleId);
        List<ISale> GetAll();
    }
}
