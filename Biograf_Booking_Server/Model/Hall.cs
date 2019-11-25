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

        private DateTime ShowDate;

        public DateTime showDate
        {
            get { return ShowDate; }
            set { ShowDate = value; }
        }
        


    }
}
