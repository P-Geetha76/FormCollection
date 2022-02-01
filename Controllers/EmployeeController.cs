using FormCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormCollection.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            MVC_DBEntities1 dbContext = new MVC_DBEntities1();
            List<Employee> empList = dbContext.Employees.ToList();
            return View(empList);
        }
    }
}