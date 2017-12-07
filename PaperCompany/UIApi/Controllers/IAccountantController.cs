using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.UI.Api.Controllers
{
    public interface IAccountantController
    {
        void WriteReport(string accountantId, string reportDescription, string orderId);
        void LoadView();
    }
}
