using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.WarehouseAPI;

namespace Company.Entity.ExportWarehouse
{
    class Export : IDelivery
    {
        public DateTime DeliveryDate { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int DeliveryId { get; set; }
    }
}
