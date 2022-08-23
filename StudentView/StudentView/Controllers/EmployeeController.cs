using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentView.Models;

namespace StudentView.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ViewResult Add()
        {
            return View();
        }

        public ViewResult list()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmployeeId = 1,Name = "xxxx",salary = 2234222},
                new Employee() { EmployeeId = 2,Name = "xxxx",salary = 764522},
                new Employee() { EmployeeId = 3,Name = "xxxx",salary = 2342},
                new Employee() { EmployeeId = 4,Name = "xxxx",salary = 2222},
                new Employee() { EmployeeId = 5,Name = "xxxx",salary = 234},
                new Employee() { EmployeeId = 6,Name = "xxxx",salary = 56222},
                new Employee() { EmployeeId = 7,Name = "xxxx",salary = 4122},
            };
            return View(employees);
        }

        public ViewResult New()
        {
            return View();
        }

        [HttpPost]
        public ViewResult New(Employee em)
        {
            return View("Display", em);
        }
    }
}