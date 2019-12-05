using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Database
{
    interface ICustomerRepository<T> where T : class
    {
        List<T> GetCustomers();
        string GetSaltFromCustomerByEmail(string email);
        Customer LogOn(string email, string pass);
        bool InsertCustomer(Customer c);
        Customer GetTopCustomer();
    }
}
