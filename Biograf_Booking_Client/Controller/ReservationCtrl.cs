using Biograf_Booking_Client.Model;

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
        public bool InsertReservation(Reservation r)
        {
            return ResSer.InsertReservation(r);
        }

        
    }
}
