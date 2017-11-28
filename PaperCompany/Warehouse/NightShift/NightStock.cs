using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.NightShift
{
    class NightStock : IStock
    {
        public DateTime ManufactureDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int QuantityInStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ProductID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
