using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Model
{
    public class Reservation
    {
        public int Date
        {
            get { return Date; }
            set { Date = value; }
        }
        public int Time
        {
            get { return Time; }
            set { Time = value; }
        }
        public int ReservationId
        {
            get { return ReservationId; }
            set { ReservationId = value; }
        }
        public int CustomerId
        {
            get { return CustomerId; }
            set { CustomerId = value; }
        }
        public int MovieId
        {
            get { return MovieId; }
            set { MovieId = value; }
        }
        public int SeatId
        {
            get { return SeatId; }
            set { SeatId = value; }
        }

        public List<int> Seats { get; set; }

    }
}
