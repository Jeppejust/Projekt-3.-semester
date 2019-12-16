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
        private SeatService sService = new SeatService();

        public ActionResult SeatBooking()
        {
            if (Session["CustomerId"] != null)
            {
                return View(sService.FindSeatsByHallId(1));
            }
            else
            {
                return RedirectToAction("Login", "Customer");
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