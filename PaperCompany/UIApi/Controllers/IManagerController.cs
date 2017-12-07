using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCompany.UI.Api.Controllers
{
    public interface IManagerController
    {
        void CreateAccountant(string firstName, string lastName);
        void CreateSalesman(string firstName, string lastName);
        string GetAllEmployees();
        void DeliverProductsToWarehouse(int quantity, string source);
        string GetProduct(string productId);
        string GetAllProducts();
        void LoadView();
    }
}
