using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkthroughEighteen.Context;
using WalkthroughEighteen.Models;

namespace WalkthroughEighteen.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolContext _schoolContext;
        public StudentController(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }
        [HttpGet]
        public IActionResult Save()
        {            
            return View();
        }
        [HttpPost]
        public IActionResult Save(Student studnet)
        {
            _schoolContext.Students.Add(studnet);
            int rowAffect = _schoolContext.SaveChanges();

            if (rowAffect> 0)
            {
                ViewBag.Message = "Save Successful";
            }
            else
            {
                ViewBag.Message = "Save Failed";
            }
            return View();
        }
        public IActionResult List()
        {
            var studentDetails = _schoolContext.Students.ToList();
            return View(studentDetails);
        }

    }
}