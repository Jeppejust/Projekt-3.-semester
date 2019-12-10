using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Biograf_Booking_Web.WebService;

namespace Biograf_Booking_Web.Service
{
    public class CustomerService
    {
        public Models.Customer Login(string Email, string Password)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                Customer C = proxy.LoginCustomer(Email, Password);
                Models.Customer Cc = new Models.Customer();
                Cc.Email = C.Email;
                Cc.Password = C.Password;
                Cc.CustomerId = C.CustomerId;
                return Cc;
            }
        }
    }
}