using Biograf_Booking_Server.Database;
using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Controller
{
    class SeatCtrl
    {
        private ISeatRepository<Seat> ISeatRepo = null;

        public SeatCtrl()
        {
            ISeatRepo = new SeatRepository();
        }

        public List<Seat> FindSeatByHallId(string HallId)
        {
            return ISeatRepo.FindSeatByHallId(HallId);
        }

    }
}
