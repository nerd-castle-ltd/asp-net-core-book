using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WalkthroughTwo.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "Hello From Student Controller Index Action";
        }

        public ActionResult Details()
        {
            return Content("Hello From Student Controller Details Action");
        }
    }
}