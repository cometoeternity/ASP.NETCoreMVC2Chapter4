using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCoreMVC2Chapter4.Models;

namespace ASP.NETCoreMVC2Chapter4.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ShoppingCart shoppingCart = new ShoppingCart
            {
                Products = Product.GetProducts()
            };
            decimal cartPrice = shoppingCart.TotalPrices();
            return View("Index", new string[] { $"Total: {cartPrice}"});
        }
    }
}
