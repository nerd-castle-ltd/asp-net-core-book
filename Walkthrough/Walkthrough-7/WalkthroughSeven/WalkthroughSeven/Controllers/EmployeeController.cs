using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkthroughSeven.Models;

namespace WalkthroughSeven.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Employee employee = GetEmployeeById(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                // update database here by model
            }
            return RedirectToAction("Index");
        }


        public Employee GetEmployeeById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            List<Employee> employeeList = GetAllEmployees();
            Employee employee = employeeList.SingleOrDefault(x => x.Id == id);
            return employee;
        }
        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee(){Id = 1, Name = "Ruhul Kuddus", Age = 33},
                new Employee(){Id = 2, Name = "Asif Ahmed", Age = 23},
                new Employee(){Id = 3, Name = "Jamim Uddin", Age = 26},
                new Employee(){Id = 4, Name = "Sohel Ahmed", Age = 28},
                new Employee(){Id = 5, Name = "Nurul Absar", Age = 21},
                new Employee(){Id = 6, Name = "Sumon Kumar", Age = 36},
            };
        }
    }
}