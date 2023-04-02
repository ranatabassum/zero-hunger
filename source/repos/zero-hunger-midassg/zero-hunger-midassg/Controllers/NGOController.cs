using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zero_hunger_midassg.DB;

namespace zero_hunger_midassg.Controllers
{
    public class NGOController : Controller
    {
        // GET: NGO
        public ActionResult Index()
        {

            if (Session["Login"] != null)
            {
                return RedirectToAction("Welcome");
            }
            else
            {

                return View();
            }
        }

        [HttpPost]
        public ActionResult Index(string uname, string pass)
        {
            if (uname == "Admin" && pass == "123")
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            Session["Login"] = 1;

            return RedirectToAction("Welcome");


        }

        public ActionResult Welcome()
        {
            if (Session["Login"] == null)
            {
                return RedirectToAction("Index");
            }
            else
            {

                return View();
            }
        }
        public ActionResult Logout()
        {
            Session["Login"] = null;
            return RedirectToAction("Index");
        }







    }
}
