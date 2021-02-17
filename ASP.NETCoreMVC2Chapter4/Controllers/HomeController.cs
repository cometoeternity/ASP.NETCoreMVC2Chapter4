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
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price= 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };
            decimal cartPrice = shoppingCart.TotalPrices();
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();
            return View("Index", new string[] {
                $"Array Total: {arrayTotal}",
                $"Filter Total: {nameFilterTotal}"});
        }
    }
}
