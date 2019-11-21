using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biograf_Booking_Client.WCFService;

namespace Biograf_Booking_Client.Service
{
    class EmployeeService
    {
        public bool Login(string username, string password)
        {
            PersonServiceClient proxy = new PersonServiceClient();
            bool verified = proxy.LogOn(username, password);
            return verified;

        }
    }
}
