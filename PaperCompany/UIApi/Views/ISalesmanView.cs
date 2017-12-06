using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.UI.Api.Controllers;

namespace Company.UI.Api.Views
{
    public interface ISalesmanView
    {
        void ShowOrderInfo(string orderId, int quantity, decimal totalPrice);
        void ShowMenu();
        void AddController(ISalesmanController controller);
    }
}
