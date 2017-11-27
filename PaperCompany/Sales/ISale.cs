using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    interface ISale
    {
        int Quantity { get; set; }
        IProduct Product { get; set; }

        string CustomerName { get; set; }

        decimal GetTotal();
    }
}
