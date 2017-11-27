using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    interface IProduct
    {
        string Name { get; set; }
        string Supplier { get; set; }

        decimal Price { get; set; }

        int ID { get; set; }
    }
}
