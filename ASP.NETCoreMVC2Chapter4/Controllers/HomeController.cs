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
            var products = new[]
            {
                new {Name="Kayak", Price = 48.95M},
                new {Name = "Lifejacket", Price = 19.50M},
                new {Name = "Soccer ball", Price = 34.95M}
            };

            return View(products.Select(p=> p.Name));
        }
    }
}
