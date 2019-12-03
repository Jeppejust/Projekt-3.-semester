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
        private ReservationService ResService = new ReservationService();
        private List<Seat> seats = new List<Seat>();
        // GET: Movies
        public ActionResult ShowTimes(int id)
        {
            Movie m = MovService.GetMovie(id);
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
        public ActionResult SeatBooking()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SeatBooking(int Time, int id , Seat s, Reservation r)
        {
            r.Time = Time;
            r.MovieId = id;
            r.Date = DateTime.Now;
            r.CustomerId = 1;
            r.Seats = new List<Seat>();
            r.Seats.Add(s);
            Debug.WriteLine(r.Time + " " + r.MovieId + " " + s.SeatId);
            ResService.InsertReservation(r);
            return View();
        }

    }
}