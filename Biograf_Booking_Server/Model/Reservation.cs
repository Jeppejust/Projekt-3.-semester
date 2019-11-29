using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Model
{
    public class Reservation
    {
        
        public DateTime Date { get; set; }

        public int ReservationId { get; set; }
    
        public int CustomerId { get; set; }

        public int MovieId { get; set; }

        public List<Seat> Seats { get; set; }

    }
}
