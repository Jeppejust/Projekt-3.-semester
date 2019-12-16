using Biograf_Booking_Web.Models;
using Biograf_Booking_Web.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biograf_Booking_Web.Controllers
{
    public class MovieController : Controller
    {
        private MovieService MovService = new MovieService();

        // GET: Movies
        public ActionResult ShowTimes(int id)
        {
            Movie m = MovService.GetMovie(id);
            Session["MovieId"] = m.MovieId;
            Session["Title"] = m.Title;
            return View(m);
        }
        public ActionResult Movies()
        {
            return View(MovService.GetMovies());
        }
        public ActionResult ShowMovies()
        {
            return View(MovService.GetMovies());
        }

    }
}