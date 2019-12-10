using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Biograf_Booking_Web.WebService;

namespace Biograf_Booking_Web.Service
{
    public class CustomerService
    {
        public bool Login(string Email, string password)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                bool verified = proxy.LogOn(Email, password);
                return verified;
            }
        }
    }
}