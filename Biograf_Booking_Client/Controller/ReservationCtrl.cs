using Biograf_Booking_Client.PersonService;
using Biograf_Booking_Client.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Controller
{
    class ReservationCtrl
    {
        private ReservationService ResSer = null;
        public ReservationCtrl()
        {
            ResSer = new ReservationService();
        }
        public void InsertReservation(Reservation r)
        {
            ResSer.InsertReservation(r);
        }
    }
}
