using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.WarehouseApi;

namespace Company.Repository.WarehouseRepositoryApi
{
    public interface IDeliveryRepository
    {
        void Add(IDelivery delivery);
        void Delete(string deliveryId);
        IDelivery GetById(string deliveryId);
        List<IDelivery> GetAll();
    }
}
