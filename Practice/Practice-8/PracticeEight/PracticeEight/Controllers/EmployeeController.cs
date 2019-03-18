using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeEight.ServiceInterfaces;
using PracticeEight.Services;

namespace PracticeEight.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            var result = _employeeService.GetAllEmployees();
            return Content("Result "+result.Count);
        }
    }
}