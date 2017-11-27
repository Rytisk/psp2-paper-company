using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    interface IDelivery
    {
        DeliveryType Type { get; set; }

        DateTime DeliveryDate { get; set; }


    }
}
