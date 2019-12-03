using Biograf_Booking_Web.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biograf_Booking_Web.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        public ActionResult ReserveTime()
        {
            return View();
        }

        public ActionResult SeatBooking()
        {
            return View();
        }

    }
}