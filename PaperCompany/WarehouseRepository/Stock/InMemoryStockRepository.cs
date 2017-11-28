using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse;

namespace WarehouseRepository.Stock
{
    class InMemoryStockRepository
    {
        private List<IStock> _stocks = new List<IStock>();

        public void Add(IStock stock)
        {
            if (!_stocks.Any(x => x.StockId == stock.StockId))
            {
                _stocks.Add(stock);
            }
            else
            {
                throw new Exception("This stock already exists.");
            }
        }

        public void Delete(int stockId)
        {
            _stocks.RemoveAll(x => x.StockId == stockId);
        }

        public List<IStock> GetAll()
        {
            return _stocks;
        }

        public IStock GetById(int stockId)
        {
            return _stocks.FirstOrDefault(x => x.StockId == stockId);
        }
    }
}
