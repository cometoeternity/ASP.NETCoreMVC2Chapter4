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
        public async Task<ViewResult> Index ()
        {
            long? length = await AsyncMethods.GetPageLength();
            return View(new string[] { $"Length : {length}" });
        }
    }
}
