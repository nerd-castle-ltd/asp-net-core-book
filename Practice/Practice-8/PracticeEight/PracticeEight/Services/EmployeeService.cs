using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeEight.Models;
using PracticeEight.ServiceInterfaces;

namespace PracticeEight.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee(){ Id = 1, Name = "Himel"},
                new Employee(){ Id = 2, Name = "Tayeb"}
            };
        }
    }
}
