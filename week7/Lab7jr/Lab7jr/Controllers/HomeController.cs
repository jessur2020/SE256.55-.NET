using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab7jr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            string[] movies = { "The Wolf Of Wall Street", "Troy", "Fast And Furious", "Naturo The Last", "Spider Man" };
            ViewBag.Movies = movies;
            string[] myFavoriteColor = { "Blue", "Green", "Red", "White", "Grey"};
            ViewBag.MyFavoriteColor = myFavoriteColor;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}