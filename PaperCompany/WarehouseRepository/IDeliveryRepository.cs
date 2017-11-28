using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse;

namespace WarehouseRepository
{
    interface IDeliveryRepository
    {
        void Add(IDelivery delivery);
        void Delete(int deliveryId);
        IDelivery GetById(int deliveryId);
        List<IDelivery> GetAll();
    }
}
