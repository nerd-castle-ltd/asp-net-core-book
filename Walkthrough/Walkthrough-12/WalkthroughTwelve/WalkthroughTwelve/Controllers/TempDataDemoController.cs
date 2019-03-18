using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WalkthroughTwelve.Controllers
{
    public class TempDataDemoController : Controller
    {
        public IActionResult RequestA()
        {
            TempData["MyKey"] = "Hello TempData!";

            return RedirectToAction("RequestB");
        }
        public IActionResult RequestB()
        {
            return Content(TempData["MyKey"] as string);
        }
    }
}