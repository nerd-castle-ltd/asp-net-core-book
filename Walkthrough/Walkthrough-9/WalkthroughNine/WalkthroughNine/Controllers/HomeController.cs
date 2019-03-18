using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkthroughNine.Models;
using WalkthroughNine.ServiceInterfaces;

namespace WalkthroughNine.Controllers
{
    public class HomeController : Controller
    {
        private readonly IToDoItemService _toDoItemService;
        public HomeController(IToDoItemService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }
        public IActionResult Index()
        {

            return View(_toDoItemService.List());
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
