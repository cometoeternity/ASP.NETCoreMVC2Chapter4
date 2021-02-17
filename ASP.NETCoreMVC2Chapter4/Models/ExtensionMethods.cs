using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreMVC2Chapter4.Models
{
    public static class ExtensionMethods
    {
        public static decimal TotalPrices (this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productEnum, decimal minimumPrice)
        {
            foreach(Product prod in productEnum)
            {
                if((prod?.Price ?? 0 ) >= minimumPrice)
                {
                    yield return prod;
                }
            }
        }
        public static IEnumerable<Product> FilterByName(this IEnumerable<Product> productEnum, char firstLetter)
        {
            foreach (Product prod in productEnum)
            {
                if(prod?.Name?[0]==firstLetter)
                {
                    yield return prod;
                }
            }
        }
    }
}
