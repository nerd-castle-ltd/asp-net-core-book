using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PracticeThree.Controllers
{
    [Route("api")] //we have already api template route defined in startup class
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello From Student Controller Index Action");
        }
    }
}