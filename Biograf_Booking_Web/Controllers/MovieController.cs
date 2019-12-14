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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(Customer c)
        {

            if (ModelState.IsValidField("Email") && ModelState.IsValidField("Password"))
            {
                var obj = cService.Login(c.Email, c.Password);
                    Session["CustomerId"] = obj.CustomerId.ToString();
                    Session["PhoneNo"] = obj.PhoneNo.ToString();
                    Session["FName"] = obj.FName.ToString();
                    Session["LName"] = obj.LName.ToString();
                    return RedirectToAction("SeatBooking");
            }
            return View();
        }

        public ActionResult Registrer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registrer(Customer c)
        {
            if (ModelState.IsValid)
            {
                cService.InsertCustomer(c);
                c = cService.Login(c.Email, c.Password);
                Session["CustomerId"] = c.CustomerId.ToString();
                Session["FName"] = c.FName;
                Session["LName"] = c.LName;
                Session["PhoneNo"] = c.PhoneNo.ToString();

                return RedirectToAction("SeatBooking");
            }
            return View();
        }
    



    public ActionResult SeatBooking()
        {
            if (Session["CustomerId"] != null)
            {
                return View(sService.FindSeatsByHallId(1));
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SeatBooking(Reservation r, string reservedSeats)
        {
            r.Seats = new List<Seat>();
            string[] foundReservedSeats = null; ;
            // if reservation string (hidden field in form) has real content
            if (!string.IsNullOrWhiteSpace(reservedSeats))
            {
                Session["BookedSeats"] = reservedSeats;
                foundReservedSeats = reservedSeats.Split(':');
            }
            // Handle the reservations in some way
            if (foundReservedSeats != null && foundReservedSeats.Length > 0)
            {
                
                foreach (var aReservedSeat in foundReservedSeats)
                {
                    if (int.TryParse(aReservedSeat.ToString(), out int seatNum))
                    {
                        
                        Seat s = new Seat();
                        s.SeatId = seatNum;
                        r.Seats.Add(s);
                    }
                }
            }
            else
            {
                // what to do if no reservations
                return RedirectToAction("SeatError", "Messages", new { area = "" });
                
            }
            
            r.Time = 1500;
            r.MovieId = Int32.Parse(Session["MovieId"].ToString());
            r.Date = DateTime.Now;
            r.CustomerId = Int32.Parse(Session["CustomerId"].ToString());

            if (ResService.InsertReservation(r) == false)
            {
                return RedirectToAction("ReservationError", "Messages", new { area = "" });
            }
            else
            {
                return RedirectToAction("Confirmation", "Messages", new { area = "" });
            }

           
        }

    }
}