using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeEight.Models;
using PracticeEight.Services;

namespace PracticeEight.ServiceInterfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
    }
}
