using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.UI.Api.Controllers
{
    public interface ISalesmanController
    {
        void CreateOrder(List<string> productIds, decimal unitPrice, string salesmanId);
        void LoadView();
    }
}
