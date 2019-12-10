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
        private SeatService sService = new SeatService();
        private CustomerService cService = new CustomerService();
        
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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(Customer c)
        {
            cService.Login(c.Email, c.Password);
            if (cService.Login(c.Email, c.Password))
            {
                return RedirectToAction("SeatBooking");
            }
            else
            {
                return RedirectToAction("ShowMovies");
            }
            
        }

        public ActionResult SeatBooking(int id)
        {

            return View(sService.FindSeatsByHallId(id)); ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SeatBooking(int Time, int id, Reservation r, string reservedSeats)
        {
            r.Seats = new List<Seat>();
            string[] foundReservedSeats = null; ;
            // if reservation string (hidden field in form) has real content
            if (!string.IsNullOrWhiteSpace(reservedSeats))
            {
                foundReservedSeats = reservedSeats.Split(':');
            }
            // Handle the reservations in some way
            if (foundReservedSeats != null && foundReservedSeats.Length > 0)
            {
                foreach (var aReservedSeat in foundReservedSeats)
                {
                    if (int.TryParse(aReservedSeat.ToString(), out int seatNum))
                    {
                        Debug.WriteLine(seatNum);
                        Seat s = new Seat();
                        s.SeatId = seatNum;
                        r.Seats.Add(s);
                    }
                }
            }
            else
            {
                // what to do if no reservations
                Response.Write("Ingen sæder markeret");
                
            }
            
            r.Time = Time;
            r.MovieId = id;
            r.Date = DateTime.Now;
            r.CustomerId = 3;

            ResService.InsertReservation(r);

            return RedirectToAction("ShowMovies");
        }

    }
}