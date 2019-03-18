using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkthroughFifteen.Extensions;
using WalkthroughFifteen.Models;

namespace WalkthroughFifteen.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            HttpContext.Items.TryGetValue(HttpContextItemsMiddleware.HttpContextItemsMiddlewareKey,
                out var middlewareSetValue);
            var result = middlewareSetValue?.ToString() ?? "Middleware value not set!";
            ViewBag.Result = result;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
