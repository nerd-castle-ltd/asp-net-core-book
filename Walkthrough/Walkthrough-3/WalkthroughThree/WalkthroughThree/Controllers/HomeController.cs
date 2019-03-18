using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkthroughThree.Models;

namespace WalkthroughThree.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello From Home Controller Index Action");
        }

        [HttpGet]
        public IActionResult PageOne()
        {
            return Content("Hello Form Home Controller PageOne Action");
        }

        [HttpGet]
        public IActionResult PageTwo()
        {
            return Content("lo Form Home Controller PageTwo Action");
        }

        [HttpPost]
        public IActionResult PageTwo(int? id)
        {
            return Content("lo Form Home Controller PageTwo Action" + id);
        }







        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
