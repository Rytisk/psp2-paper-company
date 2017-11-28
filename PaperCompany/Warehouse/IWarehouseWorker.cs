using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    interface IWarehouseWorker
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetDuties();

        IDelivery MakeDelivery(IStock stock);

        void LoadStock();
    }
}
