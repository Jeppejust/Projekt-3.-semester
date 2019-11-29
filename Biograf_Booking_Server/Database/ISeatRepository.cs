using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Database
{
    interface ISeatRepository<T> where T : class
    {
        List<T> FindSeatsByHallId(int HallId);

        List<Seat> FindSeatsBySeatId(List<Seat> s);
    }
}
