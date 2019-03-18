using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using System.Diagnostics;
using WalkthroughThirteen.Models;

namespace WalkthroughThirteen.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //returns /api/product/list?foo=bar
            string url = QueryHelpers.AddQueryString("/api/product/list", "foo", "bar");

            //Multiple Parameters
            var queryParams = new Dictionary<string, string>()
            {
                {"cat", "221" },
                {"gender", "boy" },
                {"age","4,5,6" }
            };
            //returns /api/product/list?cat=221&gender=boy&age=4,5,6
            url = QueryHelpers.AddQueryString("/api/product/list", queryParams);

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


