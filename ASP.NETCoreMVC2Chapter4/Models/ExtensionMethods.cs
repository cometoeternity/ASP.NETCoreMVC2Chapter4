using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreMVC2Chapter4.Models
{
    public static class ExtensionMethods
    {
        public static decimal TotalPrices (this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
    }
}
