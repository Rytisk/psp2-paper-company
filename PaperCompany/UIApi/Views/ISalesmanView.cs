using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.UI.Api.Controllers;

namespace PaperCompany.UI.Api.Views
{
    public interface ISalesmanView
    {
        void ShowOrderInfo(string orderId, int quantity, decimal totalPrice);
        void ShowMenu();
        void AddController(ISalesmanController controller);
    }
}
