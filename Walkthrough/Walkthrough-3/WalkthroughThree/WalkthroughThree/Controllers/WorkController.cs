using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WalkthroughThree.Controllers
{
    [Route("works")]
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello From Work Controller Index Action");
        }


        [Route("PageOne")]
        public IActionResult PageOne()
        {
            return Content("Hello From Work Controller PageOne Action");
        }


        [Route("PageTwo")]
        public IActionResult PageTwo()
        {
            return Content("Hello From Work Controller PageTwo Action");
        }
    }
}