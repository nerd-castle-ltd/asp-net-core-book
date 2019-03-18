﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WalthroughEleven.Controllers
{
    public class HomeController : Controller
    {
        const string SessionName = "_Name";
        const string SessionAge = "_Age";
        public IActionResult Index()
        {
            HttpContext.Session.SetString(SessionName, "Jarvik");
            HttpContext.Session.SetInt32(SessionAge, 24);
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            ViewBag.Age = HttpContext.Session.GetInt32(SessionAge);
            ViewData["Message"] = "Asp.Net Core !!!.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }
    }
}
