using Company.Entities.SalesApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.SalesmanServiceApi
{
    public interface ISalesmanService
    {
        ISalesman CreateSalesman(string firstName, string lastName);
        List<ISalesman> GetAllSalesmans();
    }
}
