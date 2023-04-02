using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using zero_hunger_midassg.DB;

namespace zero_hunger_midassg.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Homepage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Homepage(restaurant model)
        {

            var db = new zerohungerEntities2();
            db.restaurants.Add(model);

            db.SaveChanges();
            return RedirectToAction("List");

        }
        public ActionResult List()
        {
            var db = new zerohungerEntities2();
            var restaurant = db.restaurants.ToList();
            return View(restaurant);
        }

        
        public ActionResult Edit(int id)
        {
            var db = new zerohungerEntities2();
            var rest = (from r in db.restaurants
                        where r.r_id == id
                        select r).SingleOrDefault();
            return View(rest);


        }
        [HttpPost]
        public ActionResult Edit(restaurant upRes)
        {
            var db = new zerohungerEntities2();
            var exst = (from r in db.restaurants
                        where r.r_id == upRes.r_id
                        select r).SingleOrDefault();
        

            db.Entry(exst).CurrentValues.SetValues(upRes);
            db.SaveChanges();



            return RedirectToAction("List");
        }

    }
    
}