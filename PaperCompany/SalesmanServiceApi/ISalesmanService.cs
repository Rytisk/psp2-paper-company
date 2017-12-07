using PaperCompany.Entities.SalesApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.Services.SalesmanServiceApi
{
    public interface ISalesmanService
    {
        ISalesman CreateSalesman(string firstName, string lastName);
        List<ISalesman> GetAllSalesmans();
    }
}
