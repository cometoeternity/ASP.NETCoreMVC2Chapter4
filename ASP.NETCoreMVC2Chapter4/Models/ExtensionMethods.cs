﻿using System;
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
        public static IEnumerable<Product>Filter(this IEnumerable<Product> productEnum,Func<Product, bool> selector)
        {
            foreach (Product prod in productEnum)
            {
                if (selector(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}
