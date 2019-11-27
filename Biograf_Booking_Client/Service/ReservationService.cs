using Biograf_Booking_Client.PersonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Service
{
    class ReservationService
    {
        public void InsertReservation(Reservation r)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                proxy.InsertReservation(r);
            }
        }
    }
}
