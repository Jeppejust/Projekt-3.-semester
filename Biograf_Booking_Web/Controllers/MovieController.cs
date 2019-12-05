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

        public ActionResult UpdateSeats(IList<int> Seats)
        {
            return View(Seats);
        }
        public ActionResult SeatBooking()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SeatBooking(int Time, int id, Reservation r, List<int> seats)
        {
            r.Seats = new List<Seat>();
            
            foreach (var SeatId in seats)
            {
                Seat s = new Seat();
                s.SeatId = SeatId;
                r.Seats.Add(s);
            }
            r.Time = Time;
            r.MovieId = id;
            r.Date = DateTime.Now;
            r.CustomerId = 1;
            ResService.InsertReservation(r);
            return View();
        }

    }
}