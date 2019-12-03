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

        // GET: Reservation
        public ActionResult Create()
        {
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