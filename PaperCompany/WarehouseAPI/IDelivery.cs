using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entity.WarehouseAPI
{
    public interface IDelivery
    {
        int DeliveryId { get; set; }
        DateTime DeliveryDate { get; set; }
        string Source { get; set; }
        string Destination { get; set; }
    }
}
