using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.UI.Api.Controllers;

namespace PaperCompany.UI.Api.Views
{
    public interface IManagerView
    {
        void ShowMenu();
        void AddController(IManagerController controller);
    }
}
