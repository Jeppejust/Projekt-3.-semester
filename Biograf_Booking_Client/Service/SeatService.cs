using Biograf_Booking_Client.Model;
using Biograf_Booking_Client.PersonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Service
{
    class SeatService
    {
        public List<Seat> FindSeatsByHallId(int hId)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                return null;//proxy.FindSeatsByHallId(hId);
            }
        }
    }
}
