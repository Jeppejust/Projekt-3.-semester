using Biograf_Booking_Client.Model;
using Biograf_Booking_Client.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Controller
{
    class seatCtrl
    {
        private SeatService seatService = new SeatService();
        public List<Seat> FindSeatsByHallId(int hId)
        {
            return seatService.FindSeatsByHallId(hId);
        }
    }
}
