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
    public class ReservationController : Controller
    {
        private ReservationService ResService = new ReservationService();
        private MovieService MovService = new MovieService();

        // GET: Reservation
        public ActionResult Create()
        {
            List<Movie> Movies = MovService.GetMovies();
            ViewBag.List = Movies;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reservation r)
        {
            Seat s = new Seat();
            r.Seats = new List<Seat>();
            r.Date = DateTime.Now;
            s.SeatId = 10;
            r.Seats.Add(s);
            ResService.InsertReservation(r);
            return View();
        }
    }
}