using Company.Entities.Sales.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Api
{
    public interface ISalesmanService
    {
        ISalesman CreateSalesman(string firstName, string lastName);
        List<ISalesman> GetAllSalesmans();
    }
}
