using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zero_hunger_midassg.DB;

namespace zero_hunger_midassg.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        [HttpGet]
        public ActionResult Addemployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Addemployee(employee emp)
        {
            var db = new zerohungerEntities2();
            db.employees.Add(emp);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult EmployeeList()
        {
            var db = new zerohungerEntities2();
            var emplist = db.employees.ToList();
            return View(emplist);
        }
    }
}