using Biograf_Booking_Client.PersonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Service
{
    class HallService
    {
        public List<Hall> FindHalls(int mId)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                return proxy.FindHalls(mId);
            }
        }
    }
}
