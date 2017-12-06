using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.UI.Api.Controllers;

namespace Company.UI.Api.Views
{
    public interface IManagerView
    {
        void ShowMenu();
        void AddController(IManagerController controller);
    }
}
