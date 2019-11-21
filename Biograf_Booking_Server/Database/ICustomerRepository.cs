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
    }
}
