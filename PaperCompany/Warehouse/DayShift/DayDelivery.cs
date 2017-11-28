using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.DayShift
{
    class DayDelivery : IDelivery
    {
        public DeliveryType Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DeliveryDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Source { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Destination { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
