using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperCompany.UI.Api.Controllers;

namespace PaperCompany.UI.Api.Views
{
    public interface IAccountantView
    {
        void ShowReportDetails(string reportId, string reportInfo);
        void ShowMenu();
        void AddController(IAccountantController controller);
    }
}
