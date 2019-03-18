using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkthroughFourteen.Models;

namespace WalkthroughFourteen.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Ruhul Kuddus";
            employee.Age = 22;

            return View(employee);
        }
    }
}