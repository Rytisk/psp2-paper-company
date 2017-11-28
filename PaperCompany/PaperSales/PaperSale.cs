using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entity.SalesAPI;

namespace Company.Entity.PaperSales
{
    class PaperSale : ISale
    {
        private Paper _paper;

        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public int SaleId { get; set; }

        public PaperSale(Paper paper)
        {
            _paper = paper;
        }

        public decimal GetTotal()
        {
            return Quantity * _paper.Price;
        }

        public IProduct GetProduct()
        {
            return _paper;
        }
    }
}
