using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaFilms.Controllers
{
    public class HomeController : Controller
    {
        // Return Home page view
        public ActionResult Index()
        {
            return View();
        }       
    }
}