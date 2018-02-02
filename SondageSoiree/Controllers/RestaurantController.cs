using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SondageSoiree.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult CreerRestaurant()
        {
            return View();
        }

        [HttpPost] public ActionResult CreerRestaurant(RestaurantController poResto)
        {
            return View(poResto);
        }

    }
}