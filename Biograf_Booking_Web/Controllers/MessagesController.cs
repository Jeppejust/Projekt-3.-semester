using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biograf_Booking_Web.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Message
        public ActionResult SeatError()
        {
            return View();
        }

        public ActionResult LogInError()
        {
            return View();
        }

        public ActionResult RegistrerError()
        {
            return View();
        }

        public ActionResult ReservationError()
        {
            return View();
        }

        public ActionResult Confirmation()
        {
            return View();
        }
    }
}