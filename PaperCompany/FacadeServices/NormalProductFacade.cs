using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Facade.Api;
using Company.Services.Api;

namespace Company.Facade.Services
{
    public class NormalProductFacade : IProductFacade
    {
        private IProductMaintenanceService _productMaintenanceService;

        public NormalProductFacade(IProductMaintenanceService productMaintenanceService)
        {
            _productMaintenanceService = productMaintenanceService;
        }

        public void DeliverProductsToWarehouse(int quantity, string source)
        {
            _productMaintenanceService.DeliverProductsToWarehouse(quantity, source);
        }
    }
}
