using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse;

namespace WarehouseRepository
{
    interface IStockRepository
    {
        void Add(IStock stock);
        void Delete(int stockId);
        IStock GetById(int stockId);
        List<IStock> GetAll();
    }
}
