using Biograf_Booking_Web.Models;
using Biograf_Booking_Web.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biograf_Booking_Web.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerService cService = new CustomerService();

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
                return RedirectToAction("SeatBooking", "Reservation");
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

                return RedirectToAction("SeatBooking", "Reservation");
            }
            return View();
        }
    }
}