using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Model
{
    public class Hall
    {
        public int HallId { get; set; }

        public TimeSpan ShowTime { get; set; }

        public int MovieId { get; set; }

        public DateTime ShowDate { get; set; }

        public int Rows { get; set; }

        public int TotalSeats { get; set; }
    }
}
