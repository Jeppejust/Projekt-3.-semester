using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                if (C != null)
                {

                    Cc.Email = C.Email;
                    Cc.Password = C.Password;
                    Cc.CustomerId = C.CustomerId;
                    return Cc;
                }
                else
                {
                    return null;
                }
               
            }
        }

        public bool InsertCustomer(Models.Customer C)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                if (C != null)
                {
                    Customer Cc = new Customer();
                    Cc.Email = C.Email;
                    Cc.Password = C.Password;
                    Cc.FName = C.FName;
                    Cc.LName = C.LName;
                    Cc.PhoneNo = C.PhoneNo;
                    proxy.InsertCustomer(Cc);
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }
    }
}