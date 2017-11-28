using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    public interface ISale
    {
        int SaleId { get; set; }
        int Quantity { get; set; }
        string CustomerName { get; set; }

        decimal GetTotal();
        IProduct GetProduct();
    }
}
