﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Web.Models
{
    public class Reservation
    {

        public DateTime Date { get; set; }

        public int Time { get; set; }

        public int ReservationId { get; set; }

        public int CustomerId { get; set; }

        public int MovieId { get; set; }

        public int SeatId { get; set; }

        public List<Seat> Seats { get; set; }

    }
}
