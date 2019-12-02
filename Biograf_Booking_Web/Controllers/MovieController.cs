using Biograf_Booking_Web.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biograf_Booking_Web.Controllers
{
    public class MovieController : Controller
    {
        private MovieService MovService = new MovieService();

        // GET: Movies
        public ActionResult Index()
        {
            return View(MovService.GetMovies());
        }

        public ActionResult Movies()
        {
            return View(MovService.GetMovies());
        }
        public ActionResult MoviesTest()
        {
            return View(MovService.GetMovies());
        }
    }
}