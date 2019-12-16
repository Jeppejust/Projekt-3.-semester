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
                Customer customer = null;
                Models.Customer Cc = new Models.Customer();
                if (Email != null || Password != null)
                {
                    try
                    {
                        customer = proxy.LoginCustomer(Email, Password);
                    }
                    catch (System.NullReferenceException e)
                    {
                        Debug.WriteLine(e.Message);
                        Cc = null;
                    }

                    if (customer != null)
                    {

                        Cc.Email = customer.Email;
                        Cc.Password = customer.Password;
                        Cc.CustomerId = customer.CustomerId;
                        Cc.FName = customer.FName;
                        Cc.LName = customer.LName;
                        Cc.PhoneNo = customer.PhoneNo;
                    }
                }
                return Cc;
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