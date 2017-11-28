using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.DayShift
{
    class DayShiftWorker : IWarehouseWorker
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetDuties()
        {
            throw new NotImplementedException();
        }

        public void LoadStock()
        {
            throw new NotImplementedException();
        }

        public IDelivery MakeDelivery(IStock stock)
        {
            throw new NotImplementedException();
        }
    }
}
