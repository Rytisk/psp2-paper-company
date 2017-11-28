using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entity.SalesAPI
{
    public interface IProduct
    {
        string Name { get; set; }
        string Supplier { get; set; }

        decimal Price { get; set; }

        int ProductId { get; set; }
    }
}
