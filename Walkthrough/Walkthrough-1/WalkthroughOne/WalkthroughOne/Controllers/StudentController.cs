using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WalkthroughOne.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "Hello From Student Controller Index Action Method";
        }
    }
}