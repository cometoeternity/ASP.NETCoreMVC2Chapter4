using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreMVC2Chapter4.Models
{
    public class ShoppingCart
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
